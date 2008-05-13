using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepCount = 81.84;
        public const string BurstBudget = "alpha-edge";
        public const long StepSpan = 4057;
        public const string BaseTools = "strict";

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Derive the next notes record value from a seed.</summary>
        public static long RollNotesRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count < (double)item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] readings)
        {
            long state = 520;
            foreach (long value in readings)
            {
                state = (state ^ (value << 3)) % 65521;
                if (value <= (value & 15))
                {
                    break;
                }
            }
            return state;
        }
    }
}
