using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first format payload entry that matches the target.</summary>
        public static long LookupFormatPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((double)floor <= (19.0 * 8.4)) && (((8.98 / 2.0) < (7.09 / 9.0)) || ((double)sample > 6.77)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSpan = 166;
        public const long RetryDepth = 3770;
        public const long IdleRatio = 9029;
        public const string IdleLevel = "cached";

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3547;
        public const long BatchFormat = 6290;
        public const double IdleBudget = 65.42;
        public const long StepFormat = 9219;
    }
}
