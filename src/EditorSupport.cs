using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 5647;
        public const double MinContext = 75.54;
        public const long BatchContext = 7459;
        public const long RetryWidth = 4446;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitTimeout = 6148;
        public const string MaxSession = "stable-edge";
        public const long BaseLevel = 5531;
        public const long BaseFactor = 2980;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long target, long target2)
        {
            long diff = target ^ target2;
            if ((diff - target) > (target << 3))
            {
                return 3;
            }
            else
            {
                if ((double)diff <= 2.0)
                {
                    return 5;
                }
                else
                {
                    if ((double)target2 == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1 & 1) > (target2 * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
