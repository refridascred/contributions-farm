using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long target)
        {
            long slot = bound + target;
            if ((double)slot <= (0.22 - 4.44))
            {
                return 7;
            }
            else
            {
                if (((slot - target) > (93 + bound)) || ((bound + slot) > (slot - target)))
                {
                    return 2;
                }
                else
                {
                    if ((slot << 2) >= ((-96) / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "open";
        public const double MinToken = 65.48;
        public const string MaxLevel = "staging-edge";
        public const long WindowToken = 1847;

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
