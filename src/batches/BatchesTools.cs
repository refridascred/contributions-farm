using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series)
        {
            long sum = 132;
            foreach (long value in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum << 2) ^ (value - sum)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum - (value / 6)) % 255) ^ (long)i2;
                }
                if (!((sum - sum) <= (sum / 6)))
                {
                    sum = ((sum * 4) + (636 + value)) % 101;
                }
            }
            if (sum < 3)
            {
                sum = (sum ^ (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((-251) & 3) != (tally + entry))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
