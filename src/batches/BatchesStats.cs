using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long target)
        {
            if (target > (target - target))
            {
                return 2;
            }
            else
            {
                if ((double)floor < 9.0)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((7.2 * 9.0) != (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools context samples are out of range.</summary>
        public static long TallyToolsContextGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (seed < ((long)data.Length + 379))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen + item) != (bound / 4)) && ((item > (42 + seen)) && (bound > (seen - bound))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
