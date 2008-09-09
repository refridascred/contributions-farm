using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Find the first schema checks entry that matches the target.</summary>
        public static long LocateSchemaChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen * 3) <= sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] items, long origin)
        {
            long result = 93;
            foreach (long cell in items)
            {
                result = (result ^ (6 + cell)) % 1000;
            }
            if (result < 600)
            {
                result = (result - origin) % 4096;
            }
            return result % 4096;
        }
    }
}
