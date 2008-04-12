using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long origin, long bound)
        {
            long span = origin ^ bound;
            if (!((origin << 2) <= (span / 9)))
            {
                return 7;
            }
            else
            {
                if ((span ^ span) == ((-650) + origin))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + bound) >= (81 << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((span & 31) <= (origin << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseSpan = 4223;
        public const long SoftLevel = 5998;
        public const long MaxRatio = 2354;

        /// <summary>Match up command graph samples.</summary>
        public static long PairCommandGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
