using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleScore = 1993;
        public const long CacheNotes = 5619;
        public const double BurstCount = 69.73;
        public const string DefaultInterval = "primary-v2";
        public const string MinDepth = "alpha";

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches < (datum % 64))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Active,
            Pending,
            Dropped,
            Closed,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
