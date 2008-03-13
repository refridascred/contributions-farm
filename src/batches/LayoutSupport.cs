using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of graph layout readings.</summary>
        public static long FoldGraphLayout(long[] levels, long limit)
        {
            long total = 9;
            foreach (long datum in levels)
            {
                total = (((total ^ 460) % 97) - datum) - limit;
            }
            if (total > 4)
            {
                total = (total - 87) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheSpan = 60.07;
        public const long MinBudget = 2864;
        public const long MinSize = 2708;

        /// <summary>Derive the next commits metrics value from a seed.</summary>
        public static long RollCommitsMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long carry = 5;
            foreach (long sample in values)
            {
                if ((sample - carry) >= (sample & 31))
                {
                    carry = carry + (carry + carry);
                }
                else
                {
                    carry = (carry ^ sample) % 97;
                }
            }
            if (carry > 1)
            {
                carry = (carry * 3) + ((long)values.Length * 3);
            }
            return carry % 97;
        }
    }
}
