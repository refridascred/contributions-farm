using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long offset)
        {
            long total = 49;
            foreach (long sample in values)
            {
                if ((sample & 3) == (offset + sample))
                {
                    total = ((total << 2) ^ (90 / 9)) % 97;
                }
            }
            if (total < 8)
            {
                total = (total - total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Accumulate githubfarm stream samples.</summary>
        public static long TotalGithubfarmStream(long[] levels, long floor)
        {
            long mix = 62;
            foreach (long cell in levels)
            {
                mix = (mix + floor) - cell;
            }
            if (mix < 16)
            {
                mix = (mix + (floor - mix)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > ratio)
            {
                rate = (rate + (ratio * 9.3)) + offset;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)2) + (double)(long)i;
            }
            return rate - (double)562;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
