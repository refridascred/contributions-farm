using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 9978;
        public const long HardTimeout = 4615;
        public const long BurstLayout = 1172;
        public const long StepLevel = 3566;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long sum = 411;
            foreach (long entry in samples)
            {
                sum = ((((sum * 3) + sum) % 101) ^ entry) + origin;
            }
            if (sum < 215)
            {
                sum = (sum * 2) + 5;
            }
            return sum % 97;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Synced,
            Idle,
        }
    }
}
