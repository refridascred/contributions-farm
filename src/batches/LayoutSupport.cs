using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            New,
            Dropped,
            Failed,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + datum) <= (87 * 4))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
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
