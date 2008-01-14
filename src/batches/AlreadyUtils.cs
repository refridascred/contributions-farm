using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next command support value.</summary>
        public static double SmoothCommandSupport(double scale, double span)
        {
            double scale2 = (scale + span) / 9.0;
            return scale2 + scale;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] readings)
        {
            long total = 730;
            foreach (long entry in readings)
            {
                if (((double)entry == (1.0 - 9.98)) && ((17.0 / 4.0) != (double)total))
                {
                    total = ((total * 3) + (481 + total)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + mix) > (mix + bound))
                {
                    mix = ((mix * 4) + ((long)i + (long)i)) % 65521;
                    break;
                }
                else
                {
                    mix = ((mix * 2) + bound) % 101;
                    mix = (mix * 3) + mix;
                }
                if (!(((double)mix == (7.8 - 13.0)) && (bound > (bound - bound))))
                {
                    mix = (mix - (75 >> 1)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
