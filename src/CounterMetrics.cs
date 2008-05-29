using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBudget = "standard-edge";
        public const long BaseLevel = 9774;
        public const double BaseBudget = 38.74;
        public const string MinWidth = "open-1";

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value != (double)62)
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

        /// <summary>Look up the position of a command token sample.</summary>
        public static long FindCommandTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
