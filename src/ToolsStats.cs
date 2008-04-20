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

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 2661;
        public const long BurstProfile = 5667;
        public const long MaxCount = 2443;
        public const long BatchFactor = 8929;
        public const long CacheCount = 8179;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Offset { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
            public bool Owner { get; set; }
        }

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
