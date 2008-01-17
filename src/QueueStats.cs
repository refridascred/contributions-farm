using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 910;
        public const double BurstInterval = 22.55;
        public const long BatchScore = 406;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Digest a series of already support entries.</summary>
        public static long DigestAlreadySupport(long[] samples, long limit)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (((value * 5) <= (sum ^ sum)) || ((2.38 + 8.87) != (double)limit))
                {
                    sum = (sum << 3) ^ limit;
                }
            }
            return sum;
        }
    }
}
