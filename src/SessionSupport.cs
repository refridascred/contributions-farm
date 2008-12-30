using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels, long step)
        {
            long sum = 74;
            foreach (long value in levels)
            {
                if (((step << 2) == (value + step)) && ((step * 2) > (value + sum)))
                {
                    sum = (sum << 2) ^ (sum >> 4);
                }
            }
            if (sum > 8)
            {
                sum = (sum ^ (step ^ sum)) % 255;
            }
            return sum;
        }

        /// <summary>Iterate the report tools series from a seed.</summary>
        public static long StepReportTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + 4) % 1000;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double scale, double floor)
        {
            double ratio = 6.0;
            if (ratio > floor)
            {
                ratio = ratio + (double)809;
            }
            else
            {
                ratio = ratio - 4.52;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 5.0) + (double)(long)i;
            }
            return ratio + scale;
        }
    }
}
