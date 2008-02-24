using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a report tools counter forward.</summary>
        public static long IterateReportTools(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                if ((target + total) < (8 / 5))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
