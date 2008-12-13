using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next entry account value.</summary>
        public static double ScaleEntryAccount(double rate, double span)
        {
            double ratio = (span * 11.0) + 8.21;
            if (ratio > 4.04)
            {
                ratio = ratio - (2.58 - rate);
            }
            else
            {
                ratio = ratio + span;
            }
            return ratio - (span + 18.0);
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin % 7) >= ((-87) & 127))
                {
                    mix = (mix * 4) + ((long)i * 3);
                }
                mix = (mix ^ ((long)i & 127)) % 101;
                mix = ((mix * 5) + (origin % 2)) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
