using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((5.02 - 8.6) >= (double)reading) && !((count + reading) > (count / 9)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long seed, long floor)
        {
            long prev = seed ^ floor;
            if (((seed - floor) < (seed ^ prev)) && (64 <= (prev - floor)))
            {
                return 5;
            }
            else
            {
                if ((prev * 2) != (floor * 3))
                {
                    return 4;
                }
                else
                {
                    if ((prev << 3) == (prev + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)seed == (0.8 + 4.27)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + cell) < (654 + cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
