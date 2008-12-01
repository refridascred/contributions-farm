using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            New,
            Dropped,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((reading / 2) <= tally))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
