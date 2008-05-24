using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftCount = 4639;
        public const string IdleDepth = "standard";
        public const long BaseAlready = 8719;
        public const long StepScore = 9232;
        public const long WindowTimeout = 7305;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally >= (item + item)) && !(((long)series.Length + item) > (tally << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= (cell << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
