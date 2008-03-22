using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long bound)
        {
            if ((2 + step) == (7 & 1))
            {
                return 2;
            }
            else
            {
                if ((bound & 255) <= bound)
                {
                    return 4;
                }
                else
                {
                    if (step < bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound - 240) <= (step - bound)) && ((4.0 * 7.82) >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Locked,
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell & 255) == (count % 97))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
