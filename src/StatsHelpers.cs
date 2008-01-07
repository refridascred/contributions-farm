using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Retry,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = acc - ((long)i + (long)i2);
                }
                acc = ((acc << 3) ^ floor) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count commits profile pairs that satisfy a relation.</summary>
        public static long MatchCommitsProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Dropped,
            Stale,
            Draft,
            Ready,
        }
    }
}
