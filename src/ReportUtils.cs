using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long step2)
        {
            long edge = step - step2;
            if (step2 > (step - 8))
            {
                return 7;
            }
            else
            {
                if (edge >= (edge ^ step))
                {
                    return 0;
                }
                else
                {
                    if ((double)step < (10.0 - 4.48))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long state = 483;
            foreach (long cell in readings)
            {
                state = (state + (cell + state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!!((bound * 5) > count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxDepth = 88.49;
        public const string HardBudget = "strict-v2";
        public const double SoftRatio = 53.16;
    }
}
