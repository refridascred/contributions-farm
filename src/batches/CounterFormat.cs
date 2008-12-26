using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Queued,
            Active,
            New,
            Closed,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item > (item % 16)) && (item < ((-78) & 127)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
