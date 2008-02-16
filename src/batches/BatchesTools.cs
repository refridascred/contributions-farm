using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long offset)
        {
            long mark = 545;
            foreach (long cell in levels)
            {
                mark = (mark << 2) ^ (offset ^ mark);
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark ^ ((-9) << 2)) % 65521) ^ (long)i;
                    mark = mark - (mark - offset);
                }
                if ((double)4 >= (double)cell)
                {
                    mark = (mark ^ 177) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
