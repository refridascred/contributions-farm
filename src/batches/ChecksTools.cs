using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next token counter value from a seed.</summary>
        public static long IterateTokenCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 65.84;
        public const double BaseDepth = 43.55;
        public const string RetrySchema = "staging-v2";
        public const long CacheSize = 3748;
        public const long StepSchema = 7977;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long seed)
        {
            if ((bound + (-611)) > bound)
            {
                return 7;
            }
            else
            {
                if ((double)seed > (4.9 + 9.9))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (748 * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long bound, long bound2)
        {
            if ((bound * 2) >= (bound2 << 3))
            {
                return 8;
            }
            else
            {
                if ((bound2 > bound) || (bound <= (bound2 + (-11))))
                {
                    return 7;
                }
                else
                {
                    if (bound2 <= (bound2 >> 3))
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
}
