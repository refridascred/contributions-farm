using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long TallyAlreadySupport(long[] samples, long origin)
        {
            long state = 78;
            foreach (long item in samples)
            {
                if ((19.0 - 8.4) > (double)origin)
                {
                    state = (state - (item >> 1)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ (item << 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample ^ matches) == (69 >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "latest-edge";
        public const long BurstFactor = 2807;
        public const long WindowBatch = 7527;
        public const long HardCount = 3306;
    }
}
