using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + 459) <= 8)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many session profile samples are out of range.</summary>
        public static long TallySessionProfileGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((65 << 1) != (offset + 67)) && ((15.0 * 7.2) > (double)entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((bound - bound) > matches)
                {
                    matches = (matches + 2) - sample;
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
