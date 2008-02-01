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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            if ((step - (-4)) < (step >> 2))
            {
                return 2;
            }
            else
            {
                if ((step % 10) <= (58 >> 1))
                {
                    return 1;
                }
                else
                {
                    if (377 > (step ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "strict-1";
        public const string SoftSchema = "legacy-edge";
        public const long DefaultSchema = 6429;

        /// <summary>Grade a format stats value against two limits.</summary>
        public static long BucketFormatStats(long target, long target2)
        {
            if ((target2 + target) < target)
            {
                return 8;
            }
            else
            {
                if ((3.68 - 16.0) <= (double)target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
