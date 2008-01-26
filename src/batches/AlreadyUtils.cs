using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long step)
        {
            long gap = offset + step;
            if (!((19 ^ step) != ((-1) ^ gap)))
            {
                return 3;
            }
            else
            {
                if (((offset ^ offset) > offset) || ((double)gap > (double)(-3)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double gain, double offset)
        {
            double ratio = gain;
            if (ratio < (double)854)
            {
                ratio = (ratio - (double)716) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + 1.6) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item >= (item + (-489))) || ((8 ^ matches) > (matches << 3)))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values)
        {
            long score = 9;
            foreach (long cell in values)
            {
                score = score + cell;
                if ((score + cell) < (score - cell))
                {
                    break;
                }
            }
            if (score < 131)
            {
                score = (score << 2) ^ 761;
            }
            return score;
        }
    }
}
