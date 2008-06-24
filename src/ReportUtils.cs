using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first support editor entry that matches the target.</summary>
        public static long FindSupportEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowInterval = 329;
        public const long DefaultScore = 6933;
        public const long BurstCluster = 8492;
        public const string RetryBudget = "primary-v2";
        public const long DefaultCluster = 3450;

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples, long bound)
        {
            long anchor = 6;
            foreach (long cell in samples)
            {
                if ((cell << 2) >= cell)
                {
                    anchor = (anchor * 5) + (cell - bound);
                }
                if ((cell * 5) == (bound + cell))
                {
                    anchor = (anchor * 4) + (cell / 8);
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor > 51)
            {
                anchor = (anchor + bound) % 97;
            }
            return anchor;
        }
    }
}
