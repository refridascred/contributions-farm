using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((5.2 + 7.72) == (double)origin)
                {
                    result = result - ((long)i - result);
                }
                else
                {
                    result = (result ^ (long)i) % 97;
                    result = ((result << 2) ^ origin) % 65521;
                }
                result = ((result << 2) ^ (origin + origin)) % 101;
                if (result <= origin)
                {
                    result = ((result << 3) ^ 97) % 4096;
                    result = (result << 3) ^ (37 % 3);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples, long seed)
        {
            long acc = 468;
            foreach (long cell in samples)
            {
                acc = (acc + cell) + seed;
            }
            if (acc > 5)
            {
                acc = acc + (acc / 4);
            }
            return acc;
        }
    }
}
