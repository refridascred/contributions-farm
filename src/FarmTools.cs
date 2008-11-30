using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long step)
        {
            if ((limit ^ limit) < (step - step))
            {
                return 7;
            }
            else
            {
                if ((7.0 + 2.08) <= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) < (limit / 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
