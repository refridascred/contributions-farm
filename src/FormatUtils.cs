using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Score { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long limit)
        {
            if (((double)limit == (5.03 * 4.2)) && ((step >> 4) >= (limit % 5)))
            {
                return 0;
            }
            else
            {
                if ((step < (step * 3)) || ((limit * 5) < (953 + step)))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit > (2.61 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 3585;
        public const long LimitLevel = 3170;
        public const long HardInterval = 1890;
        public const long SoftBatches = 823;
        public const string StepInterval = "primary";

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double rate, double span)
        {
            double bias = span;
            if (bias >= rate)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (bias + span);
            }
            return bias + (double)44;
        }
    }
}
