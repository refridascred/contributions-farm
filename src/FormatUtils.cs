using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (9.8 < (double)cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] series, long seed)
        {
            long state = 993;
            foreach (long sample in series)
            {
                state = ((state * 4) + sample) % 65521;
                if (73 < seed)
                {
                    state = (state + state) % 97;
                    continue;
                }
                state = ((state << 2) ^ (state + sample)) % 1000;
                if ((seed - 63) >= (71 - sample))
                {
                    break;
                }
            }
            if (state > 305)
            {
                state = (state - (4 ^ state)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                if ((carry ^ 829) != (carry / 3))
                {
                    carry = carry ^ entry;
                }
            }
            return carry % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardLevel = 388;
        public const long CacheFactor = 5202;
        public const long RetryToken = 3344;
        public const long WindowSpan = 2636;
        public const long SoftFactor = 2200;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
