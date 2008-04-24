using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double rate, double offset)
        {
            double mean = (double)820 + (5.93 / 3.0);
            if (mean <= (mean / 5.0))
            {
                mean = mean + (offset + 4.69);
            }
            else
            {
                mean = mean - rate;
            }
            return mean - (rate * 1.0);
        }

        /// <summary>Grade a entry filter value against two limits.</summary>
        public static long RankEntryFilter(long seed, long bound)
        {
            if (((seed & 127) >= (seed - seed)) || ((seed - bound) > (7 / 7)))
            {
                return 2;
            }
            else
            {
                if (((double)seed != (6.0 / 7.0)) || ((seed + bound) != (bound + seed)))
                {
                    return 8;
                }
                else
                {
                    if ((seed & 7) == (6 & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
