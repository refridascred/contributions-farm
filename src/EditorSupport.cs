using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 9084;
        public const string MaxRatio = "strict-v2";
        public const long RetryCommits = 3289;
        public const string BaseDepth = "primary-1";
        public const long BaseCommits = 8231;

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data)
        {
            long score = 5;
            foreach (long value in data)
            {
                score = (((score * 4) + (score >> 5)) % 101) ^ value;
            }
            if (score < 7)
            {
                score = ((score * 2) + (164 - 66)) % 1000;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((88 << 3) <= (cell << 2))
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long step)
        {
            long step2 = offset - step;
            if ((20.0 + 9.0) <= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((step * 4) <= step2)
                {
                    return 0;
                }
                else
                {
                    if (((double)step2 <= (1.95 - 9.09)) && ((step2 + 2) >= (offset & 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseFactor = 5025;
        public const long HardGraph = 3662;
        public const string IdleGraph = "staging-v2";

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double scale = weight - (bias * 15.0);
            if (scale < 0.5)
            {
                scale = scale + (weight - 3.8);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale / 9.0);
        }
    }
}
