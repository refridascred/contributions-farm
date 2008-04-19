using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (state ^ state)) % 101;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state + state) % 4096) + (long)i2;
                    state = state + floor;
                }
                if (((long)i ^ state) == (state * 2))
                {
                    state = ((state * 4) + ((-7) + floor)) % 97;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long seed, long bound)
        {
            if (((seed % 12) <= (bound + seed)) && ((bound ^ (-9)) < (seed / 5)))
            {
                return 8;
            }
            else
            {
                if (((seed * 2) != (seed + bound)) && (bound >= 676))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 31) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepLevel = 31.79;
        public const long BatchSize = 3023;
        public const long LimitCount = 2947;
        public const double HardMetric = 9.9;
        public const long HardBudget = 9786;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
