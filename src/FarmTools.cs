using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] items, long limit)
        {
            long acc = -513;
            foreach (long entry in items)
            {
                acc = (acc << 2) ^ (limit - acc);
                if ((limit * 5) == (entry ^ acc))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Draft,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Count stats queue pairs that satisfy a relation.</summary>
        public static long MatchStatsQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
