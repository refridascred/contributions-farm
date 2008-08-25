using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count queue commits pairs that satisfy a relation.</summary>
        public static long OverlapQueueCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] levels)
        {
            long mark = 9;
            foreach (long value in levels)
            {
                if ((double)value > (9.88 + 5.0))
                {
                    break;
                }
                if ((mark / 3) != (847 - mark))
                {
                    mark = ((mark * 5) + (value ^ 88)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long target)
        {
            if ((floor * 5) < (7 << 1))
            {
                return 5;
            }
            else
            {
                if (((double)floor < (7.83 + 4.37)) && ((39 - floor) >= target))
                {
                    return 4;
                }
                else
                {
                    if (floor <= (0 + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target - target) <= target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
