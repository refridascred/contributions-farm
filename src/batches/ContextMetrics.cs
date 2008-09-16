using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches >= (double)2)
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long bound, long bound2)
        {
            if ((bound + 75) == (bound - 9))
            {
                return 6;
            }
            else
            {
                if ((bound % 60) != (bound % 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (20.0 < (double)seen)
                {
                    seen = ((seen + 2) ^ entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "open-1";
        public const long IdleSize = 1823;
        public const long SoftWidth = 6099;
        public const long BaseFactor = 9108;
        public const string HardScore = "stable-v2";

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long acc = 60;
            foreach (long reading in values)
            {
                if ((acc > 367) && ((double)reading > (double)bound))
                {
                    acc = acc ^ (bound + 964);
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 2) ^ (bound - acc)) % 65521;
            }
            return acc;
        }
    }
}
