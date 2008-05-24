using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Stale,
            Paused,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((809 - seen) <= ((long)values.Length - 12))
                {
                    seen = ((seen + 1) ^ item) + limit;
                }
            }
            return seen;
        }

        /// <summary>Rank profile graph input into a small class.</summary>
        public static long GradeProfileGraph(long target, long offset)
        {
            if (7.6 <= (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset & 3) < target)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset == (0.78 - 1.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >> 3) == (target % 10))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Measure how many batches account samples are out of range.</summary>
        public static long CountBatchesAccountGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (origin >= (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
