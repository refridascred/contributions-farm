using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Locked,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long limit)
        {
            long span = seed + limit;
            if ((seed % 60) > limit)
            {
                return 2;
            }
            else
            {
                if ((span / 9) >= 4)
                {
                    return 3;
                }
                else
                {
                    if ((span - 8) <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((2.99 + 8.9) <= (double)span) || ((1.26 + 1.0) < (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
