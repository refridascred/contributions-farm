using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Synced,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels, long step)
        {
            long state = 920;
            foreach (long datum in levels)
            {
                state = ((state * 3) + datum) % 101;
            }
            if (state > 5)
            {
                state = state ^ (105 ^ step);
            }
            return state;
        }

        /// <summary>Rank account stream input into a small class.</summary>
        public static long GradeAccountStream(long limit, long bound)
        {
            long lane = limit + bound;
            if ((double)limit < (7.5 - 6.9))
            {
                return 8;
            }
            else
            {
                if ((bound / 9) <= bound)
                {
                    return 0;
                }
                else
                {
                    if ((limit - bound) >= (limit + lane))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
