using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 49.98;
        public const double MinScore = 94.01;
        public const string StepCache = "open-v2";
        public const string BaseCache = "strict-v2";
        public const double BurstCache = 5.37;

        /// <summary>Check that every entry format entry stays within the limit.</summary>
        public static bool GuardEntryFormatBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
