using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Locked,
            Closed,
            Idle,
            New,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double span)
        {
            double bias = (double)(4 + 5);
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)(long)i) - span;
            }
            return bias + weight;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data)
        {
            long result = 6;
            foreach (long item in data)
            {
                if (!((result + 663) < (item / 2)))
                {
                    result = ((result << 2) ^ result) % 4096;
                }
                else
                {
                    result = ((result * 4) + result) % 101;
                }
            }
            return result;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] data, long seed)
        {
            long state = -574;
            foreach (long entry in data)
            {
                if ((double)seed != (double)83)
                {
                    state = (state << 3) ^ (seed + 0);
                }
                if ((entry - (-8)) >= ((-46) * 5))
                {
                    break;
                }
            }
            return state;
        }
    }
}
