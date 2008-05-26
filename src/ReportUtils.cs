using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)state >= 9.6)
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 4622;
        public const string MinInterval = "primary-v2";
        public const double HardAccount = 93.28;
        public const double RetryCount = 61.08;
        public const string BatchScore = "fallback-1";

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of profile counter readings.</summary>
        public static long TallyProfileCounter(long[] values)
        {
            long mix = -60;
            foreach (long value in values)
            {
                if (!(((long)values.Length <= (value + mix)) && (((-710) + 1) <= value)))
                {
                    mix = mix + (value ^ value);
                }
                if ((8.1 - 8.91) < (double)value)
                {
                    mix = ((mix * 4) + (989 + value)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
