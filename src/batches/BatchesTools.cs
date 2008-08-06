using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long target, long floor)
        {
            if ((3 + 569) < (target & 3))
            {
                return 7;
            }
            else
            {
                if ((67 << 1) != (floor / 7))
                {
                    return 3;
                }
                else
                {
                    if (((floor - floor) >= (target - floor)) && ((776 & 255) > target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowSpan = 78.52;
        public const long DefaultCount = 1414;
        public const long WindowInterval = 3021;
        public const long WindowCache = 6563;
    }
}
