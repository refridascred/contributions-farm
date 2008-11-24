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

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels)
        {
            long acc = 24;
            foreach (long entry in levels)
            {
                acc = (acc - (acc * 4)) % 1000;
                if ((acc + entry) == ((-29) + acc))
                {
                    acc = ((acc * 4) + (260 - entry)) % 1000;
                }
            }
            return acc;
        }

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

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
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
