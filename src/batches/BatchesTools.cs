using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate stream contributi readings against a bound.</summary>
        public static bool CheckStreamContributiLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order format entries that pass the check.</summary>
        public static long TallyOrderFormatMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < (double)seed) || ((seed < (seed + reading)) || ((reading - seed) < seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
