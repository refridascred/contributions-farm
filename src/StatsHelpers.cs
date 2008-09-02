using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] levels, long target)
        {
            long score = -4;
            foreach (long sample in levels)
            {
                if (target >= (target * 2))
                {
                    score = ((score * 2) + (score - 5)) % 1000;
                }
                else
                {
                    score = ((score * 4) + target) % 65521;
                }
                if ((double)sample >= 11.0)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values)
        {
            long state = 59;
            foreach (long value in values)
            {
                state = ((state * 3) + (value + state)) % 97;
            }
            return state;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the stats filter entries that pass the check.</summary>
        public static long AuditStatsFilterOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((floor ^ tally) > (floor & 1)) || ((floor + tally) >= (tally - floor)))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
