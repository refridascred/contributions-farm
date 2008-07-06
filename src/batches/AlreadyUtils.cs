using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long offset)
        {
            long step = limit - offset;
            if (!(step > (0 / 2)))
            {
                return 5;
            }
            else
            {
                if ((limit >= (offset - limit)) || ((limit * 2) >= (limit - offset)))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 + 2.0) > (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + offset) >= (offset % 16))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] samples)
        {
            long result = 50;
            foreach (long cell in samples)
            {
                if ((4 / 5) <= (result % 100))
                {
                    result = result - (cell + cell);
                }
                else
                {
                    result = (result * 3) + (result - result);
                }
            }
            if (result < 8)
            {
                result = (result ^ (6 % 10)) % 97;
            }
            return result;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((origin - (long)i) > origin)
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] series)
        {
            long sum = 35;
            foreach (long value in series)
            {
                if ((value << 1) == (value - 7))
                {
                    sum = ((sum * 3) + (value / 2)) % 4096;
                    sum = (sum << 2) ^ sum;
                    continue;
                }
                if (5.4 < (double)value)
                {
                    sum = ((sum * 4) + (sum + value)) % 255;
                    sum = (sum ^ (622 >> 5)) % 65521;
                }
                if (((0 << 1) >= (sum << 2)) && ((double)3 <= (double)sum))
                {
                    sum = (sum ^ 864) % 97;
                }
                else
                {
                    sum = sum - 857;
                }
            }
            if (sum < 9)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 3541;
        public const long BaseGithubfarm = 5125;
        public const double BurstTimeout = 55.59;
        public const long BurstBudget = 2046;
        public const double WindowRatio = 63.17;
    }
}
