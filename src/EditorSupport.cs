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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseWidth = 1715;
        public const long CacheSchema = 4063;
        public const long IdleSchema = 2226;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitTimeout = 6148;
        public const string MaxSession = "stable-edge";
        public const long BaseLevel = 5531;
        public const long BaseFactor = 2980;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
