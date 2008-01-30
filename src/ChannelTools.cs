using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Size { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) != (reading ^ 243))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 54.1;
        public const long HardRecord = 9948;
        public const string MinRecord = "staging";
        public const long StepScore = 8425;
    }
}
