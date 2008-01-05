using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((7.97 / 6.0) == (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank contributi record input into a small class.</summary>
        public static long ClassifyContributiRecord(long origin, long bound)
        {
            long diff = origin - bound;
            if (((bound << 1) >= (origin - origin)) && ((diff ^ 83) == (diff >> 5)))
            {
                return 7;
            }
            else
            {
                if (bound >= (origin * 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double mean = bias2;
            if (mean <= (double)282)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - bias;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long score = 108;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 3) + score) ^ (long)i) - item;
                }
                score = score + score;
            }
            if (score > 1)
            {
                score = score - (946 + score);
            }
            return score;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings)
        {
            long state = 7;
            foreach (long item in readings)
            {
                state = state + (item >> 5);
            }
            return state;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double bias, double bias2)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = gain + (double)40;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + bias2) + (double)(long)i;
            }
            return gain - 9.9;
        }
    }
}
