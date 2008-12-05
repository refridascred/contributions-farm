using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 4969;
        public const long HardSupport = 4474;
        public const long SoftFactor = 9067;
        public const long HardCount = 3967;
        public const long WindowSupport = 5058;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Ready,
            Retry,
            Locked,
            Paused,
            New,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Queued,
            Active,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double gain, double floor)
        {
            double drift = floor;
            if (drift < (double)7)
            {
                drift = (drift - (6.4 - floor)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
