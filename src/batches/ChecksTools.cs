using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < 11.0)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Locked,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Compare every pair of cluster buffer readings.</summary>
        public static long MatchClusterBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
