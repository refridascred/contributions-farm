using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Failed,
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Classify a stats cache pair into a bucket.</summary>
        public static long ClassifyStatsCache(long target, long origin)
        {
            if ((target & 15) <= origin)
            {
                return 6;
            }
            else
            {
                if ((4.11 / 8.0) == (double)target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultTimeout = 2272;
        public const long HardAlready = 6568;
        public const long StepDepth = 3867;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "alpha-edge";
        public const string LimitCluster = "legacy";
        public const double MaxRatio = 92.75;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
