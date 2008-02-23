using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items)
        {
            long total = 0;
            foreach (long datum in items)
            {
                total = ((total << 3) ^ (total ^ datum)) % 4096;
                if ((datum <= (total - datum)) && ((datum ^ datum) <= (datum ^ total)))
                {
                    total = ((total * 2) + (total >> 4)) % 255;
                }
                else
                {
                    total = ((total * 4) + (total - total)) % 65521;
                }
            }
            if (total < 36)
            {
                total = (total ^ (total % 7)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long offset)
        {
            long step = limit + offset;
            if ((limit * 3) != (offset + limit))
            {
                return 3;
            }
            else
            {
                if ((limit + step) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < (16.0 - 8.35))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
