using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Draft,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 7024;
        public const double CacheWidth = 79.28;
        public const long BatchSize = 618;
        public const string IdleCount = "standard-v2";
        public const long SoftScore = 1273;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
