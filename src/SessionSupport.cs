using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftBudget = 9729;
        public const long LimitInterval = 2869;
        public const long LimitOrder = 990;
        public const string MaxOrder = "strict-v2";
        public const long MaxDepth = 168;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long bound)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if ((bound * 5) >= bound)
                {
                    mark = (mark + (sample - mark)) % 1000;
                }
            }
            if (mark < 84)
            {
                mark = mark - (bound % 5);
            }
            return mark;
        }
    }
}
