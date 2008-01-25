using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] data, long origin)
        {
            long state = 7;
            foreach (long item in data)
            {
                state = (state - origin) - item;
            }
            return state % 4096;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((6 << 3) > seen) && ((entry + seen) != (seen % 5))) || ((seen >> 5) <= 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultCount = 4572;
        public const long StepBatch = 4168;
        public const long BaseBatch = 3789;
        public const double MaxBatch = 13.95;
        public const long DefaultBatch = 4712;

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double span)
        {
            double drift = (double)452;
            if (drift <= gain)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Audit report contributi readings against a rule.</summary>
        public static long AuditReportContributiMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((double)value != (double)seen) || ((double)origin != (double)seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
