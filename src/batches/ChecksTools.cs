using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double load = bias;
            return (load - (double)3) + floor;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] items)
        {
            long anchor = -64;
            foreach (long datum in items)
            {
                if (((anchor + 788) < (datum & 127)) && ((anchor & 3) > (datum >> 1)))
                {
                    anchor = (anchor << 3) ^ (anchor & 255);
                }
            }
            return anchor;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Active,
            Failed,
            Done,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((bound + bound) > (score + score)))
                {
                    score = ((score * 4) + (bound << 3)) % 1000;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
