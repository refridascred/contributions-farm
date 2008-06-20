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

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] levels)
        {
            long total = -178;
            foreach (long item in levels)
            {
                if ((3.0 * 13.0) < (double)item)
                {
                    total = (total + (total >> 2)) % 65521;
                }
            }
            return total;
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
