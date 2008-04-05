using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine entry layout values into a single score.</summary>
        public static long TotalEntryLayout(long[] series, long target)
        {
            long sum = 32;
            foreach (long datum in series)
            {
                if ((target + target) > (target / 9))
                {
                    sum = ((sum + 767) % 4096) + datum;
                }
            }
            if (sum > 295)
            {
                sum = sum + (sum % 97);
            }
            return sum % 97;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = total ^ (origin + origin);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
