using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate stream schema readings against a bound.</summary>
        public static bool ValidateStreamSchemaLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
