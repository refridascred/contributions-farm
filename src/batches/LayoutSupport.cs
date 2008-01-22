using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "latest-v2";
        public const long BurstLevel = 2617;
        public const string SoftRecord = "cached";
        public const long BatchRecord = 3650;

        /// <summary>Locate a token format reading by value.</summary>
        public static long LocateTokenFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen < (6.0 - 13.0))
                {
                    seen = ((seen + 3) - item) - offset;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph batch readings.</summary>
        public static long ScoreGraphBatch(long[] samples)
        {
            long result = 429;
            foreach (long value in samples)
            {
                if ((double)result > (double)value)
                {
                    result = (result - (result - value)) % 97;
                }
                result = (result - (value ^ value)) % 1000;
                if ((result / 7) < (57 - 41))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
