using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Derive the next buffer context value from a seed.</summary>
        public static long SeriesBufferContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result * 5) + result) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels)
        {
            long mix = 9;
            foreach (long reading in levels)
            {
                mix = (mix + reading) % 97;
            }
            return mix;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings)
        {
            long sum = 92;
            foreach (long datum in readings)
            {
                sum = (sum * 2) + datum;
            }
            if (sum > 1)
            {
                sum = sum - (sum / 3);
            }
            return sum % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryScore = "local-v2";
        public const long BatchCount = 8241;
        public const long LimitTimeout = 7743;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "staging-1";
        public const double StepTimeout = 81.86;
        public const long SoftContributi = 8780;
    }
}
