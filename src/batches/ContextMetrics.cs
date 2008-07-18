using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((((count + cell) == (cell + count)) && ((count - cell) <= (count >> 5))) && !((cell - cell) == (count - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading ^ tally) >= limit)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((target >> 1) != (matches * 2)) || !(datum >= (datum - (-9))))
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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen >> 2) != (seen & 7))
                {
                    seen = ((seen + 3) ^ item) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
