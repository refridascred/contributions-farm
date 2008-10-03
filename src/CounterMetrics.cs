using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (floor <= (floor - 9))
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Locked,
            Done,
            Ready,
            Active,
        }
    }
}
