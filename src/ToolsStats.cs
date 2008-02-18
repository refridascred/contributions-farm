using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 36.48;
        public const string BurstFactor = "standard-1";
        public const double IdleLevel = 22.14;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Draft,
            Active,
            Done,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 8808;
        public const long RetrySpan = 12;
        public const long SoftSession = 918;
        public const long DefaultSession = 7016;
        public const long IdleSpan = 2141;

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values)
        {
            long mix = 557;
            foreach (long sample in values)
            {
                mix = mix - (sample * 4);
                mix = mix - (sample / 4);
            }
            if (mix < 5)
            {
                mix = ((mix << 2) ^ (mix - 993)) % 97;
            }
            return mix;
        }
    }
}
