using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count == (12.0 / 7.0))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long state = 288;
            foreach (long sample in items)
            {
                if (((state & 7) > (state << 2)) || ((13.0 + 2.4) <= (double)state))
                {
                    state = (state - 29) ^ sample;
                }
                else
                {
                    state = state - (2 << 1);
                }
            }
            if (state < 58)
            {
                state = (state + (state & 63)) % 65521;
            }
            return state;
        }

        /// <summary>Count the stats queue entries that pass the check.</summary>
        public static long MeasureStatsQueueMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample % 16) >= ((long)readings.Length + 1))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
