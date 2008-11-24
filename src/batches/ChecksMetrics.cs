using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long offset, long seed)
        {
            if (590 <= (offset - offset))
            {
                return 6;
            }
            else
            {
                if ((seed >> 4) < (offset - seed))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleBudget = "stable-edge";
        public const double MaxReport = 70.75;
        public const long LimitSize = 7173;
        public const long CacheReport = 7944;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double span)
        {
            double weight = span;
            if (weight >= (span * 9.0))
            {
                weight = (weight - (span + span)) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + 11.0;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
