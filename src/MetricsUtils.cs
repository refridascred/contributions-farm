using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSpan = 1446;
        public const long HardOrder = 9366;
        public const long LimitScore = 2178;
        public const long WindowRatio = 9239;

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long floor2)
        {
            if ((floor2 >= (floor2 + floor)) || (5 < (floor & 255)))
            {
                return 2;
            }
            else
            {
                if ((floor << 3) > (floor2 >> 1))
                {
                    return 4;
                }
                else
                {
                    if (((floor + floor2) <= floor) || ((floor & 7) < (floor + floor2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate report profile samples.</summary>
        public static long WeighReportProfile(long[] readings, long offset)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                if ((1.45 + 6.87) > (double)offset)
                {
                    state = (state + sample) % 255;
                }
                else
                {
                    state = state ^ (state % 8);
                }
                if ((double)sample > (double)state)
                {
                    break;
                }
            }
            if (state < 5)
            {
                state = ((state * 3) + (state * 5)) % 1000;
            }
            return state;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((tally - 870) > tally))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
