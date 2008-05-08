using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry - count) != (count * 3)) && ((double)entry <= (7.9 - 10.0)))
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double scale, double floor)
        {
            double load = scale;
            if (load < (6.59 * 0.9))
            {
                load = (load + load) + floor;
            }
            return load - (load * 14.0);
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double bias)
        {
            double gain = bias + (bias / 3.0);
            if (gain <= (gain * 4.01))
            {
                gain = gain - (rate * 8.24);
            }
            return gain + (bias + 16.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 1069;
        public const long IdleRoute = 6076;
        public const string BurstRoute = "stable";
    }
}
