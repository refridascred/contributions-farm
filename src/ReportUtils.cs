using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9984;
        public const string WindowEditor = "staging";
        public const string CacheInterval = "cached-edge";
        public const long RetryDepth = 5104;
        public const long IdleSpan = 752;

        /// <summary>Count the tools editor entries that pass the check.</summary>
        public static long CountToolsEditorMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits >> 5) <= (datum % 16))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every command metric entry stays within the limit.</summary>
        public static bool CheckCommandMetricRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of commits counter readings.</summary>
        public static long WeighCommitsCounter(long[] levels, long floor)
        {
            long carry = 598;
            foreach (long entry in levels)
            {
                if (entry > (entry >> 3))
                {
                    carry = (carry - (floor + 793)) % 65521;
                }
                else
                {
                    carry = carry - (entry - 735);
                }
            }
            return carry;
        }
    }
}
