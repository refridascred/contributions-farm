using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((5.6 + 3.0) != (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (bound >= 661)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen <= (floor >> 2)) && ((seen ^ reading) == (seen + floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches + value) > 95) && ((matches + 149) >= (matches << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Dropped,
            Ready,
        }
    }
}
