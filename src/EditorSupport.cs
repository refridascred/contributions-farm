using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 4083;
        public const long DefaultAccount = 9489;
        public const string BaseAccount = "latest-v2";
        public const string DefaultTimeout = "primary-edge";
        public const string WindowAccount = "fallback-1";

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data)
        {
            long score = 5;
            foreach (long value in data)
            {
                score = (((score * 4) + (score >> 5)) % 101) ^ value;
            }
            if (score < 7)
            {
                score = ((score * 2) + (164 - 66)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every channel batches entry stays within the limit.</summary>
        public static bool CheckChannelBatchesLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 5033;
        public const string HardInterval = "fallback-edge";
        public const long MinTools = 4173;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
