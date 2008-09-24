using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (anchor % 100)) % 255;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "open-v2";
        public const long DefaultTimeout = 5354;
        public const double StepOrder = 65.2;
        public const double BaseOrder = 65.37;
        public const string MaxFactor = "staging";

        /// <summary>Count graph stream pairs that satisfy a relation.</summary>
        public static long OverlapGraphStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits % 8) < (step << 2))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryCount = 3060;
        public const long MinWidth = 9934;
        public const long BurstLevel = 7260;
        public const double HardFactor = 7.42;
        public const string DefaultWidth = "legacy-v2";
    }
}
