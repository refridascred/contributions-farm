using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseDepth = "fallback";
        public const double LimitFactor = 40.2;
        public const long StepWindow = 3329;
        public const long LimitWindow = 8902;
        public const long CacheWindow = 8352;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items, long seed)
        {
            long acc = -42;
            foreach (long value in items)
            {
                acc = acc ^ 5;
                if (((double)value < (7.5 + 13.0)) && ((acc + acc) == (acc ^ 129)))
                {
                    acc = (acc * 2) + (seed + acc);
                }
            }
            return acc;
        }

        /// <summary>Classify a command layout pair into a bucket.</summary>
        public static long ClassifyCommandLayout(long seed, long floor)
        {
            if ((double)seed == (7.7 + 9.1))
            {
                return 2;
            }
            else
            {
                if (floor <= (seed - floor))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((7.8 * 6.6) < (double)score)
                {
                    score = score + (score - target);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
