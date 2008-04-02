using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of stats order readings.</summary>
        public static long PairStatsOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "staging-v2";
        public const long SoftSpan = 8657;
        public const long MinBatch = 5340;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count editor cluster pairs that satisfy a relation.</summary>
        public static long OverlapEditorClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
