using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 3659;
        public const double BurstRatio = 5.75;
        public const long MaxSpan = 8131;
        public const string HardInterval = "standard-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "standard-1";
        public const double RetryEditor = 54.08;
        public const string SoftRatio = "local-edge";
        public const string BaseScore = "fallback-edge";

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] values)
        {
            long score = 7;
            foreach (long sample in values)
            {
                score = (score - (sample & 15)) % 1000;
                if (((861 - 22) != (score - 947)) || ((double)sample == (4.58 - 15.0)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Dropped,
            Stale,
            Locked,
            Active,
        }
    }
}
