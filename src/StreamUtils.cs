using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)cell < (2.0 + 17.0)) || !(cell < (floor ^ floor)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 3880;
        public const double BaseDepth = 66.1;
        public const long LimitTimeout = 241;

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] items, long limit)
        {
            long state = 71;
            foreach (long reading in items)
            {
                if ((state >> 4) <= state)
                {
                    state = ((state - (929 / 2)) % 97) + reading;
                }
            }
            if (state < 400)
            {
                state = state - limit;
            }
            return state;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long offset)
        {
            long result = 38;
            foreach (long reading in levels)
            {
                result = (result + (reading + reading)) + offset;
            }
            if (result < 8)
            {
                result = (result ^ 2) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Classify a batches payload pair into a bucket.</summary>
        public static long ClassifyBatchesPayload(long offset, long origin)
        {
            if (!((offset / 8) < offset))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) == (offset + origin))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
