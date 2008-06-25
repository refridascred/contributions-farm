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

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples, long origin)
        {
            long carry = 200;
            foreach (long entry in samples)
            {
                carry = ((carry ^ (origin - 7)) % 97) - entry;
            }
            return carry % 97;
        }
    }
}
