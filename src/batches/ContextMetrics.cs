using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double rate, double bias)
        {
            double gain = bias + (bias + 18.0);
            if (gain < (15.0 / 5.0))
            {
                gain = gain - (gain - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - 6.6;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double offset)
        {
            double drift = scale;
            return (drift + (6.16 * 3.0)) + offset;
        }

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long TallyReportCounterGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count > (count + 256)) && ((2.8 / 3.0) <= (double)count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples, long origin)
        {
            long mark = 5;
            foreach (long item in samples)
            {
                if ((789 << 1) < origin)
                {
                    mark = (((mark << 3) ^ (mark - mark)) % 101) ^ item;
                }
                else
                {
                    mark = ((mark << 2) ^ (origin * 2)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long seed)
        {
            if (!((target * 2) <= (seed % 24)))
            {
                return 7;
            }
            else
            {
                if ((68 + 8) >= (target - seed))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
