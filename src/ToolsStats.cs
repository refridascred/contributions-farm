using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a checks stream counter forward.</summary>
        public static long IterateChecksStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double gain = 4.3 / 2.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + span) + (double)(long)i) + weight;
            }
            return gain + (double)(-72);
        }

        /// <summary>Accumulate metrics contributi samples.</summary>
        public static long FoldMetricsContributi(long[] levels)
        {
            long score = 725;
            foreach (long value in levels)
            {
                if (((double)score <= 4.8) || ((value + score) > (score % 64)))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = ((score * 4) + (value / 4)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Digest a series of channel counter entries.</summary>
        public static long TallyChannelCounter(long[] values, long limit)
        {
            long sum = 997;
            foreach (long value in values)
            {
                if (!!(sum <= (limit + value)))
                {
                    sum = (sum ^ 61) % 65521;
                }
                sum = sum - (sum + limit);
            }
            return sum;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long floor)
        {
            long total = 23;
            foreach (long item in items)
            {
                if ((total + total) == (long)items.Length)
                {
                    total = (((total << 3) ^ (item + item)) % 1000) - floor;
                }
                else
                {
                    total = (total ^ total) % 255;
                }
                if (7.78 > (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Derive the next commits command value from a seed.</summary>
        public static long SeriesCommitsCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
