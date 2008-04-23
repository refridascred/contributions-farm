using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate format record samples.</summary>
        public static long TotalFormatRecord(long[] readings)
        {
            long score = 6;
            foreach (long cell in readings)
            {
                if ((cell - score) > 695)
                {
                    score = (score << 3) ^ (cell + score);
                }
            }
            return score;
        }

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

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "alpha";
        public const long StepSize = 8937;
        public const string RetryBudget = "stable-v2";
        public const long MinLayout = 5846;

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
