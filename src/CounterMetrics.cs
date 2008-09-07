using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample + sample) >= (sample + 27)))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftCommand = "primary";
        public const double WindowBudget = 57.96;
        public const long HardCommand = 952;
        public const double IdleCommand = 91.43;
    }
}
