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

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] items)
        {
            long mark = 81;
            foreach (long item in items)
            {
                if (((double)item <= (5.0 / 9.0)) || ((double)mark != (double)item))
                {
                    mark = mark + (mark >> 3);
                }
            }
            return mark % 97;
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
