using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + carry) < 960)
                {
                    carry = (carry ^ carry) % 255;
                }
                long cur = carry;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry - (cur / 5)) % 255) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftLevel = 5995;
        public const long CacheLevel = 5010;
        public const long StepRatio = 5750;
        public const string HardInterval = "staging-edge";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
