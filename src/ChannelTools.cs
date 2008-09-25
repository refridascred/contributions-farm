using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((floor + tally) < (cell - cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowWidth = 2183;
        public const double IdlePayload = 77.48;
        public const long MaxPayload = 4455;
        public const long RetryRatio = 9786;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((97 ^ item) <= floor) || ((item - item) <= (tally / 6)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
