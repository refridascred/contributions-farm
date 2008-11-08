using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSpan = 9948;
        public const long LimitDepth = 712;
        public const long HardSchema = 5875;
        public const long DefaultSchema = 6194;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 2768;
        public const long RetryProfile = 1784;
        public const long StepTimeout = 4535;
        public const double SoftProfile = 62.46;
    }
}
