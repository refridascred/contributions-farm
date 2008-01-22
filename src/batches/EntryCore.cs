using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheInterval = "fallback";
        public const string HardWidth = "local-1";
        public const long CacheEditor = 3395;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result << 2) ^ ((long)i + target);
                if ((14.0 / 5.0) < (double)result)
                {
                    result = result - (target + 10);
                }
                else
                {
                    result = (result - ((long)i & 7)) % 1000;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
