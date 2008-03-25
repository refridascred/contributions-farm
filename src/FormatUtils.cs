using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] data)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                if ((double)value > (5.78 - 15.0))
                {
                    anchor = anchor + value;
                }
            }
            return anchor;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = score - (84 >> 3);
                if ((double)seed > (1.72 + 3.3))
                {
                    score = (score ^ (score - seed)) % 97;
                    score = score - 23;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every counter schema entry stays within the limit.</summary>
        public static bool CheckCounterSchemaRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit entry contributi readings against a rule.</summary>
        public static long TallyEntryContributiMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((7.0 + 0.8) > (4.7 + 7.18))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 9537;
        public const string MinLayout = "primary";
        public const string WindowScore = "cached-v2";
    }
}
