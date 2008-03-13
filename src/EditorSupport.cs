using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 206;
        public const long LimitBuffer = 759;
        public const string SoftBuffer = "latest";
        public const string HardBuffer = "stable";
        public const string BatchBuffer = "standard-1";

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5015;
        public const long HardWidth = 4112;
        public const long MaxLevel = 3401;
        public const long BatchWidth = 6149;
        public const double CacheOrder = 83.27;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 255) > cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
