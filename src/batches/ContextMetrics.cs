using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "legacy-edge";
        public const long WindowAccount = 1096;
        public const double IdleAccount = 50.21;
        public const long SoftAccount = 5475;
        public const long HardScore = 3782;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Measure how many format counter samples are out of range.</summary>
        public static long AuditFormatCounterGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + (-164)) > (long)data.Length)
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 1226;
        public const long BaseOrder = 8717;
        public const long IdleOrder = 6845;
    }
}
