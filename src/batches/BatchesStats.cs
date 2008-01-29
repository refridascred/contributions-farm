using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 586;
            foreach (long entry in series)
            {
                if ((double)acc < 5.0)
                {
                    acc = ((acc << 2) ^ (entry + entry)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                if (limit >= (limit - anchor))
                {
                    anchor = anchor - (anchor + anchor);
                    continue;
                }
                else
                {
                    long delta = limit + (limit + limit);
                    anchor = (anchor * 2) + (delta - (-57));
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                result = (result - (cell & 31)) % 4096;
            }
            if (result < 360)
            {
                result = (result - (result & 7)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Ready,
            Done,
            Synced,
            Retry,
            Active,
        }
    }
}
