using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many support order samples are out of range.</summary>
        public static long TallySupportOrderGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum > matches)
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Pending,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
