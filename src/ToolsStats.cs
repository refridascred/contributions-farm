using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine farm graph values into a single score.</summary>
        public static long DigestFarmGraph(long[] levels)
        {
            long score = 3;
            foreach (long value in levels)
            {
                score = score + value;
                if (((double)score > (5.0 + 2.9)) || ((double)value != (7.89 * 8.33)))
                {
                    score = (score - value) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSpan = 7902;
        public const long MinChannel = 634;
        public const double StepChannel = 38.45;
        public const long BaseChannel = 4982;
        public const string BurstCount = "open-v2";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long bound)
        {
            if (((double)floor > (double)1) && ((bound + bound) >= 994))
            {
                return 6;
            }
            else
            {
                if ((floor - bound) >= (6 % 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 97) < (818 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound >= floor) && ((bound + floor) == (25 / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long origin, long target)
        {
            if ((origin - target) != (origin & 1))
            {
                return 8;
            }
            else
            {
                if (origin <= (target & 1))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) >= (target % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target <= (origin + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((result + result) < (offset - result)) && ((offset << 2) >= 2))
                {
                    result = result - (offset + (-8));
                    result = (result << 3) ^ ((-2) * 2);
                }
                result = result - (result + result);
                if ((double)(long)i < (1.5 / 3.0))
                {
                    result = result + (result + offset);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double drift = (span / 2.0) * 4.32;
            if (drift >= drift)
            {
                drift = drift + (drift + drift);
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (drift + weight);
        }
    }
}
