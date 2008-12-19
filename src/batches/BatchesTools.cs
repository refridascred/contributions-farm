using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (entry + 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings, long target)
        {
            long result = 130;
            foreach (long datum in readings)
            {
                if (((4.54 + 1.2) != (double)(long)readings.Length) && ((52 - 191) < target))
                {
                    result = (((result << 2) ^ target) % 1000) ^ datum;
                }
            }
            if (result < 534)
            {
                result = (result - (result + result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
