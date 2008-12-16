using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit stats batches readings against a rule.</summary>
        public static long MeasureStatsBatchesHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((88 + tally) < (limit / 7))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 9501;
        public const string StepSize = "local-v2";
        public const long StepWidth = 6656;
        public const long BaseCount = 1590;

        /// <summary>Grade a window contributi value against two limits.</summary>
        public static long SortWindowContributi(long limit, long offset)
        {
            if ((double)limit >= (double)offset)
            {
                return 0;
            }
            else
            {
                if (offset >= 86)
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) >= (offset ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double offset)
        {
            double ratio = (weight + offset) + (weight * 19.0);
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
