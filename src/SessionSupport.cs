using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 4723;
        public const long SoftTimeout = 7506;
        public const long MaxSpan = 9249;
        public const long LimitGraph = 8781;
        public const long WindowScore = 1577;

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples, long bound)
        {
            long mix = 82;
            foreach (long value in samples)
            {
                mix = (mix ^ (bound + mix)) % 65521;
                if (!((0.1 * 5.0) > (double)value))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
