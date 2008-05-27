using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits >> 5) <= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchScore = 7427;
        public const long MinSize = 834;
        public const long StepWidth = 1767;
        public const double StepTimeout = 36.97;
        public const long DefaultDepth = 3108;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}
