using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items)
        {
            long acc = 46;
            foreach (long datum in items)
            {
                acc = (acc ^ acc) % 97;
                if (acc <= (long)items.Length)
                {
                    acc = (acc << 2) ^ (datum ^ 4);
                }
            }
            return acc;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long floor)
        {
            if ((target + 6) != (target & 255))
            {
                return 0;
            }
            else
            {
                if ((6.9 * 3.7) >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor > (3.4 * 5.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
