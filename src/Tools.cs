using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Audit filter farm readings against a rule.</summary>
        public static long CountFilterFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally - 2) > (cell % 100))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter account samples.</summary>
        public static long TallyFilterAccount(long[] levels, long limit)
        {
            long score = -11;
            foreach (long datum in levels)
            {
                if ((limit ^ limit) < 499)
                {
                    score = (score ^ score) ^ datum;
                }
                if ((8.95 + 2.9) <= (double)score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 1805;
        public const double IdleGithubfarm = 32.93;
        public const double LimitGithubfarm = 56.7;
        public const string LimitRatio = "primary-edge";

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long floor)
        {
            if ((11 ^ step) <= ((-5) % 16))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (8.0 + 13.0))
                {
                    return 7;
                }
                else
                {
                    if (step > (step & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor <= (step - floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double bias2 = (double)(67 - 67);
            if (bias2 < 8.67)
            {
                bias2 = ((bias2 - (double)915) - rate) - bias;
            }
            return bias2 + (double)651;
        }
    }
}
