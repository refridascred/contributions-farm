using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (step <= (item << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 4910;
        public const long SoftBatch = 6323;
        public const string BatchSpan = "open-edge";
        public const string MinBatch = "cached";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Pending,
            Active,
            Queued,
            Paused,
        }
    }
}
