using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (739 < matches)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
