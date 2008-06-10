using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long seed)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                acc = (((acc * 5) + (acc + acc)) - sample) - seed;
            }
            return acc % 65521;
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
