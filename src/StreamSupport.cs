using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine commits contributi values into a single score.</summary>
        public static long TotalCommitsContributi(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                if ((entry >> 2) > entry)
                {
                    continue;
                }
                if (entry > sum)
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
                else
                {
                    sum = (sum * 2) + (sum + entry);
                }
                if ((sum >= (entry + 58)) && ((338 + sum) != (sum + sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long MeasureAlreadyFilterGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches > (1.49 * 4.0))
                {
                    matches = ((matches + 2) - reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
