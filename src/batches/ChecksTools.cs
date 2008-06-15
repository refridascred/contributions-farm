using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 1269;
        public const long BaseGithubfarm = 6648;
        public const long MinFactor = 5671;
        public const long MaxScore = 9171;
        public const long IdleGithubfarm = 4209;

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series, long target)
        {
            long total = 37;
            foreach (long sample in series)
            {
                if (((total >> 2) < sample) && ((14.0 - 2.74) >= (1.02 / 9.0)))
                {
                    total = ((total * 3) + (target / 3)) % 97;
                }
            }
            if (total < 86)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long step, long target)
        {
            if ((target + target) == (step / 8))
            {
                return 3;
            }
            else
            {
                if ((step - target) >= (target << 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)target < (2.1 - 0.21))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long target)
        {
            long score = 1;
            foreach (long value in series)
            {
                score = ((score * 4) + target) % 4096;
                if ((target >= (score + score)) && ((value << 1) < (value - score)))
                {
                    score = score - (score - value);
                }
                score = (score ^ (score - 71)) % 65521;
            }
            if (score < 287)
            {
                score = (score * 5) + target;
            }
            return score;
        }
    }
}
