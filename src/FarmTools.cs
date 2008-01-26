using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((target >> 5) >= 814) || (((-800) & 15) <= (item >> 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = total - ((long)i ^ 38);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
