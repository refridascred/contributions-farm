using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit cluster payload readings against a rule.</summary>
        public static long MeasureClusterPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((9.0 >= (double)entry) || (((556 % 24) == (entry - tally)) || (tally >= (entry - entry))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank tools profile input into a small class.</summary>
        public static long ClassifyToolsProfile(long limit, long offset)
        {
            if ((offset < limit) && (offset > (limit * 2)))
            {
                return 7;
            }
            else
            {
                if (((double)limit >= (0.8 - 0.59)) && ((914 - offset) >= offset))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(count > (count * 5)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
