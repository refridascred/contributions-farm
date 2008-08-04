using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstInterval = 4584;
        public const double IdleWidth = 14.43;
        public const double SoftInterval = 47.9;
        public const long RetryCommand = 828;
        public const long LimitScore = 2225;
    }
}
