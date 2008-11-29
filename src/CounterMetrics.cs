using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitDepth = 4211;
        public const long RetrySpan = 1389;
        public const long StepContributi = 8994;
        public const long RetryContributi = 3071;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((mix - mix) >= mix)
                {
                    mix = (mix - (offset & 63)) % 1000;
                    mix = (mix ^ (mix - offset)) % 101;
                }
                else
                {
                    mix = (mix ^ (mix << 3)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Owner { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }
    }
}
