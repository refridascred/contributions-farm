using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - (sum / 8)) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3510;
        public const long HardStream = 5010;
        public const double RetryStream = 47.79;
        public const long MaxStream = 2887;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long origin)
        {
            if ((step <= (origin ^ step)) || (224 >= step))
            {
                return 3;
            }
            else
            {
                if ((7.0 * 2.7) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin & 3) > (origin << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)99 == (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
