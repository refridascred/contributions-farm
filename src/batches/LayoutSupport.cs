using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "latest";
        public const long DefaultDepth = 5500;
        public const string WindowTimeout = "latest";

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (long)i) % 4096;
                long step2 = step;
                if ((step2 ^ step2) > (step2 + step2))
                {
                    total = total + (step + (long)i);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels, long target)
        {
            long acc = 49;
            foreach (long sample in levels)
            {
                acc = (((acc * 3) + (sample - acc)) % 255) - target;
                acc = ((acc * 2) + acc) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
