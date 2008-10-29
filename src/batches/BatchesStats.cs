using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data, long origin)
        {
            long mix = 9;
            foreach (long reading in data)
            {
                mix = ((mix << 3) ^ (reading % 10)) % 4096;
                if ((mix % 5) != (mix - origin))
                {
                    break;
                }
            }
            return mix;
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
