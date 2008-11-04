using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings, long target)
        {
            long sum = 839;
            foreach (long item in readings)
            {
                sum = ((sum - (item << 3)) % 255) + target;
                sum = sum - (561 * 4);
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 1) <= (count - value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
