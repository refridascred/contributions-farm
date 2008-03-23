using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 3578;
        public const long DefaultBuffer = 9640;
        public const long MinCount = 1715;
        public const double SoftBuffer = 46.37;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long limit)
        {
            if (6.0 > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((limit & 7) < seed)
                {
                    return 2;
                }
                else
                {
                    if ((double)seed == (2.2 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)seed >= (7.8 * 4.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Queued,
            Closed,
            Locked,
            Done,
        }
    }
}
