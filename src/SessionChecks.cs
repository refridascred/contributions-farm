using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1805;
        public const long StepSize = 5929;
        public const string StepAccount = "local-v2";
        public const long RetryAccount = 9375;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Active,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Derive the next window already value from a seed.</summary>
        public static long StepWindowAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + 777) % 101;
                if ((mark > limit) || (limit >= (mark ^ mark)))
                {
                    mark = ((mark << 2) ^ mark) % 255;
                }
                if ((limit + limit) >= (long)i)
                {
                    mark = (mark * 4) + (limit + (long)i);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
