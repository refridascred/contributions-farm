using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double weight2 = (double)0 * 3.58;
            if (weight2 >= span)
            {
                weight2 = weight2 - span;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + 3.8) + (double)(long)i;
            }
            return weight2 + (weight - span);
        }

        /// <summary>Count editor format pairs that satisfy a relation.</summary>
        public static long PairEditorFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double scale = bias / 6.0;
            if (scale > bias2)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)(-796)) - (double)(long)i;
            }
            return scale + (double)9;
        }
    }
}
