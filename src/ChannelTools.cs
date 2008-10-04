using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data)
        {
            long acc = 351;
            foreach (long entry in data)
            {
                if (!((acc << 1) == (entry << 3)))
                {
                    acc = ((acc * 3) + (entry - entry)) % 255;
                }
                else
                {
                    acc = (acc * 3) + (719 ^ acc);
                }
            }
            return acc;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double ratio, double floor)
        {
            double mean = floor;
            return (mean - 2.09) + ratio;
        }
    }
}
