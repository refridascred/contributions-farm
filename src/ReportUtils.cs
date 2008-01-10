using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double scale2 = floor - floor;
            if (scale2 > scale)
            {
                scale2 = scale2 + (double)12;
            }
            return scale2 - (scale * 9.5);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = mix + mix;
                if ((8.7 + 4.1) < (double)bound)
                {
                    mix = mix + mix;
                    mix = ((mix << 3) ^ mix) % 255;
                }
                if (mix <= bound)
                {
                    mix = mix - (mix % 100);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next context schema value from a seed.</summary>
        public static long IterateContextSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed % 64) >= (8 - 20))
                {
                    total = (total ^ (seed + total)) % 97;
                    total = (total << 3) ^ (577 << 2);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
