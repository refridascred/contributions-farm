using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long origin)
        {
            long slot = bound - origin;
            if ((slot - origin) < bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound > 13.0)
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 4) <= (639 + slot))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count cluster batch pairs that satisfy a relation.</summary>
        public static long OverlapClusterBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((double)count >= 8.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstWidth = 2798;
        public const long HardCount = 1261;
        public const long IdleProfile = 8570;
    }
}
