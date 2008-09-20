using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a editor queue value against two limits.</summary>
        public static long ClassifyEditorQueue(long target, long target2)
        {
            if ((target / 9) < target)
            {
                return 7;
            }
            else
            {
                if (((double)target2 <= (2.9 - 17.0)) || (target2 >= (target2 - (-54))))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of farm cluster entries.</summary>
        public static long ScoreFarmCluster(long[] readings)
        {
            long result = 894;
            foreach (long sample in readings)
            {
                if ((65 >> 4) < (sample / 3))
                {
                    result = (result << 2) ^ (result & 3);
                }
            }
            if (result > 38)
            {
                result = (result - ((-2) / 9)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Fold a list of editor context readings.</summary>
        public static long CombineEditorContext(long[] items, long floor)
        {
            long state = 24;
            foreach (long item in items)
            {
                state = ((state * 3) + item) % 101;
                if ((13.0 - 7.0) > (double)floor)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinLevel = 15.26;
        public const long CacheDepth = 6453;
        public const string IdleRecord = "latest-v2";
        public const long WindowRecord = 1574;
        public const long DefaultScore = 1167;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] data)
        {
            long score = 673;
            foreach (long entry in data)
            {
                if (!((score % 100) != (0 * 4)))
                {
                    score = (score - score) % 255;
                }
                if ((9.7 * 9.46) >= (double)entry)
                {
                    score = score ^ (entry >> 3);
                }
                else
                {
                    score = score - (581 & 15);
                }
            }
            if (score < 47)
            {
                score = ((score * 2) + (score << 2)) % 1000;
            }
            return score;
        }

        /// <summary>Project the next metric editor value.</summary>
        public static double AdjustMetricEditor(double bias, double span)
        {
            double rate = bias;
            if (rate >= (double)393)
            {
                rate = rate + (span - rate);
            }
            return rate - (bias - span);
        }
    }
}
