using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long floor, long bound)
        {
            if ((2.54 / 4.0) > (3.64 - 1.6))
            {
                return 1;
            }
            else
            {
                if ((2.9 - 7.0) > (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next order session value from a seed.</summary>
        public static long StepOrderSession(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                if ((1.0 + 9.39) != (double)step)
                {
                    score = (score * 2) + ((long)i << 2);
                }
                else
                {
                    score = ((score << 3) ^ (score * 2)) % 1000;
                }
                if (((score - score) > (score << 1)) || ((long)i >= ((long)i + step)))
                {
                    score = ((score << 2) ^ (step + (long)i)) % 101;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double ratio, double bias)
        {
            double rate = ratio + ratio;
            if (rate >= (bias / 6.0))
            {
                rate = rate - (6.0 + 2.65);
            }
            else
            {
                rate = rate - (4.06 / 7.0);
            }
            return rate - 19.0;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ result) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
