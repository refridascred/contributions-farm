using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Paused,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long bound)
        {
            long step = target + bound;
            if ((bound - step) > (step - step))
            {
                return 2;
            }
            else
            {
                if (((bound % 3) > (target - 3)) || ((3.0 * 7.0) == (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)step != (8.7 - 13.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound != (1.41 + 3.12))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Locked,
            Retry,
        }
    }
}
