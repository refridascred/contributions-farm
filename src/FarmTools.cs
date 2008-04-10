using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((63 - tally) != (value % 16))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit counter metric readings against a rule.</summary>
        public static long TallyCounterMetricGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches & 31) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every format already entry stays within the limit.</summary>
        public static bool VerifyFormatAlreadyRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
