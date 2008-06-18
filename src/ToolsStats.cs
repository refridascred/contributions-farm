using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Draft,
            Done,
            Closed,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Closed,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] levels, long step)
        {
            long acc = -55;
            foreach (long entry in levels)
            {
                if ((step + acc) >= (entry - 50))
                {
                    acc = ((acc << 2) ^ entry) % 101;
                }
            }
            return acc;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double rate, double bias)
        {
            double drift = bias;
            if (drift < bias)
            {
                drift = drift + (bias * 9.2);
            }
            else
            {
                drift = drift - rate;
            }
            return drift - drift;
        }

        /// <summary>Iterate the token report series from a seed.</summary>
        public static long RollTokenReport(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                if ((total - (long)i) <= total)
                {
                    total = (total - ((long)i % 64)) % 4096;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Total { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
