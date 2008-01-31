using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleBudget = "primary-1";
        public const double StepFilter = 24.28;
        public const long BatchInterval = 9122;
        public const long WindowFilter = 9976;
        public const string LimitFilter = "open-1";

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] data)
        {
            long score = 692;
            foreach (long value in data)
            {
                if ((score + score) <= score)
                {
                    score = (score - value) % 255;
                }
            }
            if (score > 14)
            {
                score = ((score * 4) + (10 - score)) % 255;
            }
            return score;
        }

        /// <summary>Validate support profile readings against a bound.</summary>
        public static bool CheckSupportProfileBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "strict-1";
        public const string SoftSchema = "legacy-edge";
        public const long DefaultSchema = 6429;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading / 2) <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
