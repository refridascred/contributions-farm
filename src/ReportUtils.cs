using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstInterval = 5694;
        public const double BaseDepth = 35.86;
        public const double BaseBuffer = 46.94;
        public const long IdleBuffer = 6205;

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 9529;
        public const string SoftContext = "legacy-1";
        public const double IdleInterval = 19.16;
        public const long StepScore = 7360;

        /// <summary>Classify a buffer checks pair into a bucket.</summary>
        public static long SortBufferChecks(long target, long seed)
        {
            if ((0.8 + 1.9) == (double)target)
            {
                return 5;
            }
            else
            {
                if (target >= seed)
                {
                    return 1;
                }
                else
                {
                    if ((1.0 - 8.29) != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (long)i;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank tools commits input into a small class.</summary>
        public static long SortToolsCommits(long seed, long origin)
        {
            long prev = seed - origin;
            if ((double)seed == (17.0 * 3.5))
            {
                return 1;
            }
            else
            {
                if ((0.6 * 10.0) == (double)prev)
                {
                    return 0;
                }
                else
                {
                    if (((double)prev <= (2.7 * 4.3)) || ((seed + 4) != (seed - prev)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
