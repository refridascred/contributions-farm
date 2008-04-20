using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long limit, long bound)
        {
            if (((9.4 - 3.0) == (double)limit) || ((limit / 8) >= limit))
            {
                return 1;
            }
            else
            {
                if (!((limit + limit) > limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every window already entry stays within the limit.</summary>
        public static bool GuardWindowAlreadyLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 37.97;
        public const double BurstLevel = 69.42;
        public const double HardTimeout = 71.87;
        public const long StepFarm = 4988;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 1578;
        public const long MaxCommand = 3429;
        public const long WindowWidth = 5915;
        public const double StepTimeout = 25.01;
        public const long CacheCommand = 5093;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Idle,
            Done,
            Active,
        }
    }
}
