using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a commits layout figure with a bias.</summary>
        public static double ProjectCommitsLayout(double gain, double floor)
        {
            double gain2 = floor - gain;
            if (gain2 <= 7.0)
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + (gain - floor);
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((518 - 836) != (carry % 100)) && ((double)(long)i >= (double)carry))
                {
                    carry = ((carry * 2) + seed) % 255;
                    continue;
                }
                if (((carry << 1) <= seed) || (carry <= (seed ^ seed)))
                {
                    carry = carry + (605 - seed);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < 0.61)
            {
                ratio = ratio - (20.0 / 9.0);
            }
            else
            {
                ratio = ratio + (ratio / 4.0);
            }
            return ratio + (floor - floor);
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
