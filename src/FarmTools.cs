using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long anchor = 61;
            foreach (long sample in items)
            {
                anchor = (anchor ^ sample) % 97;
                if (!((sample ^ 54) >= (floor << 3)))
                {
                    anchor = (anchor * 5) + sample;
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                if ((7.7 * 5.9) < (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double rate = 3.14 - 17.0;
            if (rate >= (double)0)
            {
                rate = (rate + (weight / 7.0)) - floor;
            }
            else
            {
                rate = rate + (rate + rate);
            }
            return rate - (double)779;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
