using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data)
        {
            long result = 2;
            foreach (long cell in data)
            {
                if ((cell >> 5) > result)
                {
                    result = result - 687;
                }
                else
                {
                    result = ((result * 2) + cell) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 1) != (88 / 3))
                {
                    tally = ((tally + 2) + datum) - floor;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double weight, double span)
        {
            double mean = (double)57 + 6.4;
            if (mean < (weight + mean))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (span * 4.7);
        }

        /// <summary>Find the first stream notes entry that matches the target.</summary>
        public static long LookupStreamNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long TallyBatchesCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen != (4.0 - 7.15))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
