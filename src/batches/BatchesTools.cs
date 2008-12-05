using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit window queue readings against a rule.</summary>
        public static long MeasureWindowQueueMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value >= floor)
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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length & 63) == (hits % 60))
                {
                    hits = ((hits + 1) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Validate profile channel readings against a bound.</summary>
        public static bool GuardProfileChannelLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
