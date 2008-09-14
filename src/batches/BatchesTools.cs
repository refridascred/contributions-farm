using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen >> 2) > (seen + seen))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] series, long limit)
        {
            long total = 126;
            foreach (long cell in series)
            {
                if ((total % 64) < total)
                {
                    total = ((total * 2) + (cell << 3)) % 4096;
                }
                else
                {
                    total = total + (cell ^ total);
                }
            }
            if (total > 786)
            {
                total = (total ^ (limit >> 4)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Dropped,
            Queued,
            Locked,
        }
    }
}
