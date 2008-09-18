using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long floor)
        {
            long result = 34;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    result = (result + (datum + floor)) % 97;
                }
                else
                {
                    result = (result * 2) + (result * 5);
                }
                if (datum > (504 << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long SortChecksBatches(long origin, long bound)
        {
            if (!((origin - bound) != (bound >> 4)))
            {
                return 6;
            }
            else
            {
                if (((6.05 - 14.0) > (double)bound) && (origin >= (bound + bound)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((seed % 8) > (matches / 6))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((origin + (long)i) == (sum / 2)) || ((sum << 1) > (sum - sum)))
                {
                    sum = sum - (origin << 3);
                    sum = (sum * 3) + origin;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4130;
        public const string MaxScore = "open-1";
        public const string LimitCount = "alpha-edge";
    }
}
