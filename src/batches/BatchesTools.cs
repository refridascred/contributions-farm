using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many command account samples are out of range.</summary>
        public static long MeasureCommandAccountHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((60 / 6) < (tally + entry))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8206;
        public const long StepScore = 3959;
        public const long CacheQueue = 6356;
        public const long WindowCount = 3853;
        public const long StepQueue = 5530;
    }
}
