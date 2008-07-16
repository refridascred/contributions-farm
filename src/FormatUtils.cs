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

        /// <summary>Locate a report commits reading by value.</summary>
        public static long LookupReportCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Ready,
            Done,
            Active,
            Idle,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double scale, double bias)
        {
            double gain = (scale + 7.0) - (scale * 5.5);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (double)56;
        }
    }
}
