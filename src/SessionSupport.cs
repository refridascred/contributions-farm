using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 484;
        public const string StepBatch = "primary-v2";
        public const long SoftSize = 4506;
        public const long DefaultBatch = 3631;
        public const double BaseScore = 44.81;

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 4079;
        public const long WindowBudget = 9116;
        public const double IdleRecord = 70.96;
        public const string DefaultRecord = "cached-edge";

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long MeasureNotesChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 3) == (28 - reading))
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
    }
}
