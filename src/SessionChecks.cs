using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double floor)
        {
            double gain = (double)(81 * 3);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + gain) + (double)(long)i) + floor;
            }
            return gain - scale;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double gain = 3.0;
            if (gain > (gain + 2.0))
            {
                gain = ((gain + gain) - bias) - floor;
            }
            else
            {
                gain = gain - (gain + gain);
            }
            return gain - (double)365;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long origin)
        {
            long edge = floor ^ origin;
            if (edge < (floor ^ edge))
            {
                return 0;
            }
            else
            {
                if (origin <= (floor - 519))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            New,
            Pending,
            Stale,
            Idle,
        }
    }
}
