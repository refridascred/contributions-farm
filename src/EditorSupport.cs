using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double scale, double floor)
        {
            double gain = floor;
            if (gain >= (double)98)
            {
                gain = gain + gain;
            }
            return gain - scale;
        }

        /// <summary>Grade a cache checks value against two limits.</summary>
        public static long GradeCacheChecks(long bound, long step)
        {
            long delta = bound - step;
            if ((7 ^ step) <= (step + bound))
            {
                return 0;
            }
            else
            {
                if ((bound ^ 805) <= (step % 8))
                {
                    return 5;
                }
                else
                {
                    if ((step + delta) >= (bound >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta < (45 / 3)) && ((bound + bound) != (step * 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long TallyClusterCounter(long[] readings)
        {
            long total = -12;
            foreach (long sample in readings)
            {
                if (!((total + sample) <= (797 - sample)))
                {
                    total = total - (sample - sample);
                }
                else
                {
                    total = ((total * 3) + 21) % 1000;
                }
            }
            return total;
        }

        /// <summary>Accumulate command cache samples.</summary>
        public static long TallyCommandCache(long[] values, long seed)
        {
            long score = 47;
            foreach (long entry in values)
            {
                if ((20.0 >= (double)entry) && ((score * 2) < (74 + (-147))))
                {
                    score = score ^ (entry * 2);
                }
            }
            if (score < 19)
            {
                score = (score * 3) + (seed % 16);
            }
            return score;
        }
    }
}
