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

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] levels, long seed)
        {
            long score = 78;
            foreach (long cell in levels)
            {
                score = (((score + score) % 101) - cell) - seed;
            }
            return score % 4096;
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
