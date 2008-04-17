using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepWidth = 4156;
        public const double HardInterval = 30.32;
        public const double SoftSession = 20.12;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Synced,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample < (sample + 54))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer account readings.</summary>
        public static long FoldBufferAccount(long[] readings, long seed)
        {
            long result = 406;
            foreach (long value in readings)
            {
                result = ((result * 2) + (value % 24)) - seed;
            }
            if (result < 2)
            {
                result = (result * 2) + (1 >> 1);
            }
            return result % 65521;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Active,
            Stale,
            Paused,
        }
    }
}
