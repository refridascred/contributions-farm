using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data)
        {
            long total = 125;
            foreach (long entry in data)
            {
                total = total ^ (total - entry);
                if ((double)total != (14.0 * 4.1))
                {
                    break;
                }
            }
            if (total < (-599))
            {
                total = (total + (total + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long seed, long floor)
        {
            if ((double)seed <= (6.0 - 1.57))
            {
                return 4;
            }
            else
            {
                if ((double)floor > (5.99 - 10.0))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double floor)
        {
            double mean = (weight * 8.91) * 5.0;
            return (mean - (double)84) + floor;
        }
    }
}
