using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Roll a profile farm counter forward.</summary>
        public static long DeriveProfileFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark << 3) ^ 5) ^ (long)i2;
                }
                if ((mark * 5) >= (mark << 3))
                {
                    mark = (mark ^ (mark + mark)) % 101;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4246;
        public const string LimitMetric = "local-edge";
        public const string MinDepth = "staging-v2";
    }
}
