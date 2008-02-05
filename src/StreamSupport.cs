using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 2339;
        public const long SoftCount = 1277;
        public const long BurstChecks = 3405;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item / 6) == (floor + item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
