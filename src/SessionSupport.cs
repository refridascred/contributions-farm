using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Idle,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long floor, long seed)
        {
            if (((522 >> 2) < seed) && (floor < seed))
            {
                return 1;
            }
            else
            {
                if ((floor << 1) > seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
