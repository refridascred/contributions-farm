using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Pending,
            Closed,
            Paused,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowScore = 5956;
        public const long LimitSession = 5674;
        public const string IdleLevel = "staging-1";
        public const long DefaultSession = 728;
        public const double IdleSession = 31.55;
    }
}
