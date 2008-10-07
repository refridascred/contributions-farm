using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Dropped,
            Locked,
            Queued,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (offset <= (seen << 1))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
