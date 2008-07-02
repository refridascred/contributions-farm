using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 9707;
        public const long MinScore = 2185;
        public const long BaseFilter = 7144;
        public const string RetryFilter = "legacy-1";

        /// <summary>Accumulate report batches samples.</summary>
        public static long TotalReportBatches(long[] data)
        {
            long mix = 5;
            foreach (long value in data)
            {
                if ((15.0 - 7.8) == (double)mix)
                {
                    mix = (mix - (value << 3)) % 65521;
                }
                mix = (mix ^ (value * 2)) % 97;
            }
            if (mix > (-724))
            {
                mix = (mix * 2) + mix;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long LookupRouteClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + mark) % 65521;
                mark = (mark << 3) ^ ((long)i * 2);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
