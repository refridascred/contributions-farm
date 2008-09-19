using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 788;
        public const long DefaultBatch = 7072;
        public const long DefaultInterval = 2683;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleInterval = 2603;
        public const long CacheCount = 7615;
        public const string DefaultEditor = "primary-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 3579;
        public const string BurstChecks = "strict-v2";
        public const long BurstLevel = 7309;
        public const long RetryChecks = 2256;

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor + (94 + floor);
                anchor = (anchor + (0 + anchor)) % 101;
                if (!(((long)i + 30) < (726 >> 2)))
                {
                    break;
                }
                else
                {
                    anchor = anchor ^ (floor >> 4);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
