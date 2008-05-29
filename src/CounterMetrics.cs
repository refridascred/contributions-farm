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

        /// <summary>Match up already buffer samples.</summary>
        public static long PairAlreadyBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
