using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items, long step)
        {
            long result = 474;
            foreach (long reading in items)
            {
                if ((reading >> 2) <= reading)
                {
                    result = ((result + 1) % 255) + step;
                }
                else
                {
                    result = (result ^ (result / 8)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstBudget = 2421;
        public const double LimitInterval = 84.72;
        public const long LimitGithubfarm = 1019;

        /// <summary>Classify a already githubfarm pair into a bucket.</summary>
        public static long ClassifyAlreadyGithubfarm(long origin, long seed)
        {
            if (((4 + (-251)) == (origin + seed)) && ((origin + origin) <= (seed % 7)))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (13.0 - 1.1))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (1.1 + 2.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long WeighStreamChannel(long[] levels)
        {
            long carry = 713;
            foreach (long value in levels)
            {
                if ((86 >> 2) <= (20 ^ value))
                {
                    carry = ((carry * 2) + (26 << 1)) % 1000;
                }
                if ((double)carry <= (5.5 + 6.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2995;
        public const long BatchTimeout = 6181;
        public const long HardInterval = 599;
    }
}
