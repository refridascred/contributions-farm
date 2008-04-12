using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultLevel = 96.02;
        public const string WindowCommand = "primary-v2";
        public const string BaseCommand = "staging-edge";
        public const string RetryWidth = "stable-edge";

        /// <summary>Roll a cache command counter forward.</summary>
        public static long SeriesCacheCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ limit) % 4096;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long sum = -7;
            foreach (long sample in samples)
            {
                sum = (sum + (946 - sample)) % 1000;
                if (0 >= sum)
                {
                    sum = sum ^ (72 << 1);
                }
                if (!((long)samples.Length >= sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
