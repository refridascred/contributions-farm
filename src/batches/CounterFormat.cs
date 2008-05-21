using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                sum = sum ^ entry;
                if ((entry + entry) != (entry + sum))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = sum ^ (65 / 8);
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of contributi format readings.</summary>
        public static long PairContributiFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] levels)
        {
            long total = 75;
            foreach (long entry in levels)
            {
                total = (total + 567) % 255;
                if (((entry + total) < (total ^ total)) && (total > 2))
                {
                    total = (total ^ (total + (-8))) % 1000;
                }
                total = (total * 4) + (entry ^ (-527));
            }
            return total % 1000;
        }
    }
}
