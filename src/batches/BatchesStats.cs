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

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
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
