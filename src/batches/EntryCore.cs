using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double gain = (double)44 / 4.0;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + rate) - (double)(long)i) - span;
            }
            return gain - gain;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 6918;
        public const string SoftLevel = "standard-1";
        public const long CacheBatch = 3977;

        /// <summary>Accumulate support record samples.</summary>
        public static long TallySupportRecord(long[] samples, long limit)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                if ((224 <= (entry * 5)) || ((entry & 127) <= (mix << 2)))
                {
                    mix = (((mix * 2) + (entry - mix)) % 255) - limit;
                }
            }
            return mix % 65521;
        }
    }
}
