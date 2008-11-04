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

        /// <summary>Accumulate command farm samples.</summary>
        public static long FoldCommandFarm(long[] samples)
        {
            long anchor = 526;
            foreach (long value in samples)
            {
                if (8.58 < (double)value)
                {
                    anchor = anchor ^ (anchor - anchor);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor - (-5))) % 97;
                }
                if (((double)anchor > (double)value) || ((14.0 * 2.99) <= (0.82 - 13.0)))
                {
                    anchor = (anchor - (value << 2)) % 101;
                }
                anchor = (anchor ^ (anchor + value)) % 97;
            }
            return anchor;
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
