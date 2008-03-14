using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 64.2;
        public const double DefaultEditor = 46.87;
        public const double BatchEditor = 47.84;
        public const string HardSize = "standard";

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 733;
        public const string RetryCount = "stable-edge";
        public const string LimitPayload = "local-edge";
        public const long IdlePayload = 1906;
        public const long LimitLevel = 2922;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long limit)
        {
            long anchor = 0;
            foreach (long entry in items)
            {
                anchor = ((anchor * 2) + (limit >> 2)) % 97;
                if (!((double)entry < (8.4 * 6.59)))
                {
                    anchor = ((anchor << 3) ^ (entry + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor * 5) + (limit + limit);
                }
            }
            return anchor;
        }
    }
}
