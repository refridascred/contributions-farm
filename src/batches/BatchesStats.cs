using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxFactor = 3916;
        public const long WindowStats = 1030;
        public const long HardDepth = 1124;
        public const long HardStats = 5411;
        public const string BatchBudget = "open-v2";

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((acc << 2) != ((long)i << 2))
                {
                    acc = ((acc << 2) ^ (acc - floor)) % 4096;
                }
                else
                {
                    acc = (acc - ((long)i - 381)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((double)sample != (15.0 * 3.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
