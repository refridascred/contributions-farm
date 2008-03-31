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

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] samples, long limit)
        {
            long state = 158;
            foreach (long reading in samples)
            {
                state = (state ^ ((-133) - 63)) - limit;
                state = state + reading;
            }
            return state;
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
