using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] values)
        {
            long state = 2;
            foreach (long reading in values)
            {
                state = (state * 3) + (state + state);
                if ((15.0 * 4.2) >= (double)reading)
                {
                    break;
                }
            }
            if (state > 99)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitRatio = "primary-1";
        public const long BurstFarm = 869;
        public const double HardFarm = 51.91;
        public const long BatchSpan = 8142;
        public const long IdleFarm = 4308;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 13.0)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            New,
            Closed,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Locked,
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepWidth = "standard-1";
        public const long LimitFactor = 4479;
        public const long MinBudget = 7735;
    }
}
