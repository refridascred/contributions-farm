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

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] items, long seed)
        {
            long carry = 17;
            foreach (long entry in items)
            {
                if (((9 + entry) > (carry - seed)) && ((5.0 * 7.26) < (double)seed))
                {
                    carry = ((carry * 3) + carry) % 97;
                }
            }
            return carry;
        }
    }
}
