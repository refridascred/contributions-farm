using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already notes samples.</summary>
        public static long TotalAlreadyNotes(long[] readings)
        {
            long sum = 92;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum * 5) + sum) - (long)i;
                }
                sum = ((sum * 5) + (sum + datum)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public bool Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstTimeout = 9;
        public const long RetryDepth = 7872;
        public const double StepSpan = 63.53;
        public const long MaxBudget = 2197;
        public const double MinBudget = 62.76;
    }
}
