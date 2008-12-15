using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double gain = ratio;
            if (gain < gain)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - (span + ratio);
            }
            return gain + 1.8;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long origin)
        {
            long score = 837;
            foreach (long sample in levels)
            {
                score = (((score * 5) + (score - 65)) % 97) - sample;
                if ((origin / 6) == (origin * 4))
                {
                    score = score - (origin + origin);
                }
                else
                {
                    score = score ^ (315 - score);
                }
                if (!(15 < (origin - score)))
                {
                    break;
                }
            }
            if (score < 37)
            {
                score = score + (99 ^ origin);
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryBudget = 3160;
        public const long MaxLayout = 3668;
        public const long LimitLayout = 66;
        public const double CacheLayout = 14.88;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double scale, double bias)
        {
            double mean = 17.0;
            if (mean < scale)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + 6.8;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (double)(-51)) - (double)(long)i;
            }
            return mean - (mean + bias);
        }
    }
}
