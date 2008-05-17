using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value < (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count % 8) < (item << 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (floor * 2.68)) + (double)(long)i;
            }
            return drift - (weight - drift);
        }
    }
}
