using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Done,
            Idle,
            New,
            Dropped,
        }

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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double drift = 3.0;
            return ((drift + (double)9) + bias) + floor;
        }
    }
}
