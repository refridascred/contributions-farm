using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Locked,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + 107) > hits) && (((31 + hits) > (hits ^ (-38))) && ((41 & 15) >= (sample + sample))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long bound, long limit)
        {
            long lane = bound ^ limit;
            if ((784 + 408) != (lane + lane))
            {
                return 6;
            }
            else
            {
                if (((bound & 255) >= (bound - (-739))) && ((7 + lane) > ((-166) - limit)))
                {
                    return 5;
                }
                else
                {
                    if ((lane / 4) <= (limit * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Paused,
            Done,
            Closed,
            Ready,
        }
    }
}
