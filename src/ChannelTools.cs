using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series, long limit)
        {
            long anchor = 3;
            foreach (long cell in series)
            {
                if (((limit / 9) != ((-98) + 6)) && ((8.33 * 6.93) == (double)limit))
                {
                    anchor = ((anchor << 3) ^ (cell ^ cell)) % 97;
                }
                else
                {
                    anchor = (anchor - cell) % 4096;
                }
            }
            if (anchor > 98)
            {
                anchor = (anchor ^ 850) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many buffer already samples are out of range.</summary>
        public static long AuditBufferAlreadyOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((hits + cell) >= (cell >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
