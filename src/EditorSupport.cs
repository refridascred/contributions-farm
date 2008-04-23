using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 6567;
        public const long BaseDepth = 3500;
        public const long MaxCount = 8037;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxDepth = 5270;
        public const double WindowTimeout = 66.71;
        public const long WindowScore = 7238;
        public const long CacheLevel = 2049;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "stable-v2";
        public const long HardRatio = 1142;
        public const long StepToken = 2815;
        public const double DefaultTimeout = 31.47;
        public const long LimitToken = 2207;

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowRatio = 5125;
        public const string CacheFactor = "alpha-edge";
        public const long MinSupport = 1708;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
