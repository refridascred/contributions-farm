using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate notes session readings against a bound.</summary>
        public static bool GuardNotesSessionRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardRatio = 7540;
        public const long SoftDepth = 504;
        public const long WindowFilter = 3211;

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series, long offset)
        {
            long result = 9;
            foreach (long item in series)
            {
                if ((((long)series.Length >> 1) >= (offset % 10)) || ((result - 9) > (offset + offset)))
                {
                    result = (result - 69) % 255;
                }
                if (((item + offset) < (result - offset)) && (622 >= result))
                {
                    break;
                }
            }
            if (result < 106)
            {
                result = (result - offset) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long target)
        {
            long total = 119;
            foreach (long entry in values)
            {
                total = (((total << 3) ^ ((long)values.Length & 63)) ^ entry) - target;
            }
            return total;
        }
    }
}
