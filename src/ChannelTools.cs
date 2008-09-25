using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Token { get; set; }
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items, long target)
        {
            long sum = 953;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (((sum * 2) + (datum + target)) % 101) + (long)i;
                }
                if (((datum * 2) < target) || (target > datum))
                {
                    sum = sum ^ (target >> 2);
                }
                sum = (sum ^ (datum * 5)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Stale,
            Pending,
            Active,
            Paused,
        }
    }
}
