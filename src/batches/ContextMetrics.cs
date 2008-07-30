using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((71 << 1) == (item >> 1))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Project the next session contributi value.</summary>
        public static double ScaleSessionContributi(double gain, double floor)
        {
            double ratio = gain;
            return (ratio - (gain + ratio)) + floor;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long bound2)
        {
            if ((bound2 + bound) >= (5 >> 2))
            {
                return 3;
            }
            else
            {
                if ((bound2 >= bound) || ((-948) >= bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound * 4) > (bound << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4.3 - 3.0) > (double)bound) || ((bound * 2) < 657))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double load = gain;
            if (load >= span)
            {
                load = load + (gain + span);
            }
            return load + (4.45 * 6.56);
        }
    }
}
