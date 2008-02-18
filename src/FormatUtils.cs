using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultFactor = 95.17;
        public const double BurstGraph = 61.78;
        public const double WindowGraph = 40.57;

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleWidth = 33.89;
        public const long BaseBudget = 3758;
        public const long StepTools = 5853;
        public const double BurstDepth = 29.55;

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 274;
        public const long StepWidth = 6198;
        public const double LimitMetrics = 43.86;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels, long floor)
        {
            long mix = -61;
            foreach (long value in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix + floor) ^ (long)i) ^ value;
                    mix = (mix ^ (floor + 3)) % 4096;
                }
                if (!(((long)levels.Length / 4) != (mix + mix)))
                {
                    mix = (mix + (floor + floor)) % 101;
                }
            }
            return mix;
        }
    }
}
