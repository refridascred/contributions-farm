using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cluster buffer entries that pass the check.</summary>
        public static long CountClusterBufferHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((offset & 15) > (seen ^ 9)) || ((reading << 2) != (4 ^ offset))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
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
            Idle,
            Synced,
            Dropped,
            Pending,
            New,
        }
    }
}
