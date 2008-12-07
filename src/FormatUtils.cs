using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > offset)
            {
                bias2 = bias2 + (bias2 / 6.0);
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (double)142;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < (seen % 10))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long bound)
        {
            if (17.0 < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound - bound) < (bound % 64))
                {
                    return 2;
                }
                else
                {
                    if ((floor - floor) == (floor + 68))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(((-5) << 1) < (22 + floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long StepBatchesMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
