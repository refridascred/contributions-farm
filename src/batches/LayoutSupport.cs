using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of channel payload readings.</summary>
        public static long TotalChannelPayload(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                if ((sum >> 3) <= value)
                {
                    sum = (sum - (sum << 2)) % 4096;
                }
                else
                {
                    sum = sum + (sum ^ value);
                }
            }
            return sum % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-v2";
        public const long BaseDepth = 8291;
        public const long SoftStats = 6467;
        public const double IdleStats = 23.13;
        public const long MaxDepth = 5691;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
