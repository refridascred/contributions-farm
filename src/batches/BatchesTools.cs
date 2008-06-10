using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count < (count + (long)samples.Length))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Grade a window graph value against two limits.</summary>
        public static long BucketWindowGraph(long floor, long seed)
        {
            long next = floor ^ seed;
            if ((seed - seed) == (next & 31))
            {
                return 8;
            }
            else
            {
                if (seed >= (seed & 7))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)target <= (9.93 / 6.0)) || (((double)matches != (0.51 + 4.42)) && (sample < (target ^ matches))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
