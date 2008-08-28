using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Draft,
            Active,
            Pending,
            Paused,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen + cell) >= cell)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
