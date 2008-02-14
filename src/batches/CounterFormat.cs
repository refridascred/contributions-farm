using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 2917;
        public const string MaxReport = "cached-1";
        public const string RetryReport = "cached-edge";
        public const long MinFactor = 6343;
        public const long DefaultReport = 681;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((limit - limit) != (tally + tally))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
