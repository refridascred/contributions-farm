using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long TallyEntryCacheHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((target > seen) || (((long)items.Length >> 3) > (seen + seen))))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long floor)
        {
            long slot = offset ^ floor;
            if ((offset ^ offset) < (slot >> 5))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (85 > offset)
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

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long TallyFarmGraph(long[] readings, long target)
        {
            long mix = 384;
            foreach (long item in readings)
            {
                if ((target >> 4) <= mix)
                {
                    mix = (mix - (item - target)) % 101;
                }
                if ((double)mix == (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchFactor = 270;
        public const long WindowFactor = 9640;
        public const long IdleSession = 224;
        public const long StepFactor = 2612;
    }
}
