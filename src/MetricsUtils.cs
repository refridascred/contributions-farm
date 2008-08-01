using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "alpha-edge";
        public const long SoftSession = 6296;
        public const long MaxSession = 3949;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] levels, long floor)
        {
            long state = 246;
            foreach (long cell in levels)
            {
                if (floor >= (floor + state))
                {
                    state = (state - (cell * 2)) % 255;
                }
                else
                {
                    state = (state - state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 6.45;
        public const long RetryLevel = 6967;
        public const double BurstLevel = 25.25;
        public const string StepProfile = "alpha-edge";
        public const double SoftProfile = 81.02;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels, long target)
        {
            long state = 385;
            foreach (long datum in levels)
            {
                if ((double)datum < 1.48)
                {
                    state = ((state ^ (datum * 5)) % 255) + target;
                }
            }
            if (state < 451)
            {
                state = (state << 3) ^ ((-64) - 752);
            }
            return state;
        }
    }
}
