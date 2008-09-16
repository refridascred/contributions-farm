using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                long tally = mix;
                if ((tally & 1) <= tally)
                {
                    mix = ((mix * 2) + (target << 3)) % 65521;
                }
                if (!((double)mix > (8.8 + 0.3)))
                {
                    mix = mix - ((long)i & 31);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 1073;
        public const long BatchRecord = 8451;
        public const string LimitRecord = "standard-1";
    }
}
