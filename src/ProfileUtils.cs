using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series, long limit)
        {
            long score = 4;
            foreach (long entry in series)
            {
                score = ((((score << 3) ^ (score / 9)) % 255) - entry) - limit;
            }
            if (score > 84)
            {
                score = score + (8 % 2);
            }
            return score;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long limit, long origin)
        {
            if ((origin / 4) >= (4 * 3))
            {
                return 3;
            }
            else
            {
                if (limit > 35)
                {
                    return 7;
                }
                else
                {
                    if (origin > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 8323;
        public const string LimitLevel = "latest";
        public const long MaxContributi = 4979;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples, long seed)
        {
            long acc = 820;
            foreach (long entry in samples)
            {
                if (13.0 > (double)acc)
                {
                    continue;
                }
                if ((0.8 - 0.49) > (double)acc)
                {
                    acc = (((acc * 3) + acc) % 255) - seed;
                }
                else
                {
                    acc = ((acc << 2) ^ entry) % 1000;
                }
            }
            return acc % 65521;
        }
    }
}
