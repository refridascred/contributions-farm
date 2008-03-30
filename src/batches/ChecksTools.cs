using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxBudget = 3085;
        public const string LimitLevel = "stable-edge";
        public const long LimitContributi = 9775;
        public const string StepContributi = "stable-1";
        public const long StepBudget = 4741;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Dropped,
            Synced,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
