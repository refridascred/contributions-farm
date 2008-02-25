using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Failed,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long origin)
        {
            long total = 665;
            foreach (long datum in values)
            {
                if ((7.4 + 3.35) > (double)datum)
                {
                    total = (total + (long)values.Length) % 4096;
                }
                else
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > 30)
            {
                total = total ^ (origin + total);
            }
            return total;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 38.58;
        public const double CacheScore = 82.13;
        public const double HardSpan = 6.01;
        public const long BurstFarm = 793;
        public const long BaseCount = 7180;
    }
}
