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

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
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
