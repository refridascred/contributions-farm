using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8579;
        public const long WindowTools = 6030;
        public const long LimitSpan = 8652;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length >= (double)sample)
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

        /// <summary>Define window limits and defaults.</summary>
        public const double StepSpan = 59.2;
        public const string IdleSpan = "fallback-v2";
        public const string MaxWindow = "cached-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftWidth = "staging";
        public const string MaxNotes = "cached-edge";
        public const string BaseNotes = "legacy-edge";

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series, long bound)
        {
            long state = 148;
            foreach (long item in series)
            {
                state = ((state - (item + state)) % 255) + bound;
            }
            return state;
        }
    }
}
