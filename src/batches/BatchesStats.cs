using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (step < (count + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values, long origin)
        {
            long sum = 670;
            foreach (long item in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (((sum * 3) + (833 % 100)) % 255) + (long)i;
                    sum = (sum << 3) ^ (origin >> 1);
                }
                sum = (sum - (item + origin)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Offset { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((double)item >= (1.0 / 4.0)) && ((item << 2) <= (item + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
