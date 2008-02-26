using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLevel = 2053;
        public const long LimitLayout = 3323;
        public const string MinInterval = "stable-1";

        /// <summary>Classify a payload queue pair into a bucket.</summary>
        public static long SortPayloadQueue(long offset, long target)
        {
            long cur = offset + target;
            if ((target + offset) <= (offset + target))
            {
                return 4;
            }
            else
            {
                if (((42 & 31) > (cur % 3)) && ((offset / 6) <= 0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
