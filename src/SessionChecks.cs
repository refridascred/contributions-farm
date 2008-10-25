using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long target, long step)
        {
            long lane = target - step;
            if ((step - target) >= (target + lane))
            {
                return 6;
            }
            else
            {
                if ((step - target) > (target - step))
                {
                    return 7;
                }
                else
                {
                    if ((step >= (64 + lane)) && ((lane * 5) < ((-713) + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Dropped,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a account layout reading by value.</summary>
        public static long SeekAccountLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
