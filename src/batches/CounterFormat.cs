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

        /// <summary>Grade a counter schema value against two limits.</summary>
        public static long ClassifyCounterSchema(long target, long seed)
        {
            long diff = target ^ seed;
            if (((target + diff) > (target * 3)) && ((double)seed > 8.77))
            {
                return 5;
            }
            else
            {
                if (((diff % 10) > diff) || ((double)diff < (20.0 + 6.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
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
