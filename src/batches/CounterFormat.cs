using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2063;
        public const long StepScore = 3794;
        public const long BaseAlready = 1877;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((14.0 + 1.0) >= (double)seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Pending,
            Retry,
            Locked,
        }
    }
}
