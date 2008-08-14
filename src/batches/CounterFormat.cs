using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (8.5 * 3.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSpan = 5510;
        public const long BatchCount = 4891;
        public const long BaseScore = 8115;
        public const long BaseInterval = 3923;
        public const long HardChecks = 5856;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
