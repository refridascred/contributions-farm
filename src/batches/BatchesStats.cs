using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (7 > (reading & 127))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] samples)
        {
            long total = 52;
            foreach (long item in samples)
            {
                if (((item & 31) < total) || (((long)samples.Length << 2) <= 1))
                {
                    total = (total ^ (total ^ item)) % 97;
                }
            }
            if (total < 785)
            {
                total = (total + (total ^ 3)) % 255;
            }
            return total;
        }

        /// <summary>Rank farm tools input into a small class.</summary>
        public static long GradeFarmTools(long offset, long target)
        {
            if (((target + 78) == (6 * 2)) || ((target - offset) < offset))
            {
                return 6;
            }
            else
            {
                if ((615 > (offset >> 4)) && ((double)target < 17.0))
                {
                    return 0;
                }
                else
                {
                    if (!((8.14 * 3.0) > (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
