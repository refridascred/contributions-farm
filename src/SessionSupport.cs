using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((long)values.Length >= count)
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardBudget = "strict-v2";
        public const string StepToken = "cached";
        public const double HardToken = 41.23;
        public const long SoftToken = 6566;
        public const long WindowFactor = 8007;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Dropped,
            Paused,
            Draft,
            Closed,
        }
    }
}
