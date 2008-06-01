using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 838;
        public const long BurstSize = 774;
        public const long LimitRecord = 982;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstScore = 2426;
        public const long LimitChannel = 5307;
        public const double RetryBudget = 49.82;
        public const long StepWidth = 8773;
        public const long RetryDepth = 3702;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((29 % 8) == ((long)readings.Length & 3))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
