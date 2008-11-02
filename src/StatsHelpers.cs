using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series, long bound)
        {
            long state = 2;
            foreach (long datum in series)
            {
                state = (state - (bound + datum)) % 4096;
                if ((datum / 8) <= bound)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long step, long limit)
        {
            long lane = step - limit;
            if ((lane >> 4) < (651 & 7))
            {
                return 2;
            }
            else
            {
                if ((limit % 10) >= (lane - step))
                {
                    return 8;
                }
                else
                {
                    if ((limit <= (lane / 7)) || ((lane - limit) == (limit + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step & 7) <= (42 << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank graph batches input into a small class.</summary>
        public static long GradeGraphBatches(long floor, long floor2)
        {
            if (((floor << 1) <= (floor2 + 404)) && (floor2 >= (floor2 / 8)))
            {
                return 8;
            }
            else
            {
                if (((floor2 * 5) != (113 * 3)) || ((floor * 5) == (floor - 38)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Stale,
            New,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Dropped,
            Synced,
            Active,
        }
    }
}
