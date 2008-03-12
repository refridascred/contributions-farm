using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next order layout value from a seed.</summary>
        public static long StepOrderLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i >= (4.75 + 19.0))
                {
                    state = state - (state + state);
                }
                else
                {
                    state = (state * 5) + seed;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((2.2 - 5.3) <= (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardWidth = 823;
        public const double LimitFarm = 39.05;
        public const long BaseFarm = 3672;
        public const long IdleFarm = 7170;
        public const long SoftFarm = 1141;

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftSize = 40.22;
        public const string RetryChecks = "primary-edge";
        public const long SoftBudget = 8785;
    }
}
