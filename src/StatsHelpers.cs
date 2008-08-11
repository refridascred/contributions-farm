using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "stable";
        public const double MinBudget = 22.93;
        public const long StepCounter = 4703;
        public const long LimitCounter = 354;

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinDepth = "legacy-v2";
        public const double SoftChannel = 70.83;
        public const double HardChannel = 76.3;
        public const double MaxChannel = 5.79;
        public const long LimitChannel = 8482;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)step > 7.19)
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
