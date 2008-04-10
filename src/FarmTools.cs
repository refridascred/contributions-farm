using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine notes layout values into a single score.</summary>
        public static long ScoreNotesLayout(long[] items, long limit)
        {
            long result = 3;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result * 4) + (value & 127)) + (long)i;
                }
                if (result < (value + limit))
                {
                    result = (result - (value << 2)) % 65521;
                }
                else
                {
                    result = (result - (result ^ value)) % 65521;
                }
            }
            if (result < (-17))
            {
                result = (result - (result & 63)) % 4096;
            }
            return result;
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
