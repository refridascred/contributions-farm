using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of window session readings.</summary>
        public static long OverlapWindowSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)160 != (double)(long)levels.Length)
                {
                    hits = ((hits + 2) + entry) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a order context counter forward.</summary>
        public static long StepOrderContext(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (long)i) % 255;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double ratio = (double)237;
            if (ratio < ratio)
            {
                ratio = ((ratio + (double)461) + bias) + offset;
            }
            return ratio + 5.7;
        }
    }
}
