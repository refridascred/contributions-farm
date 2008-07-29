using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((8 & 7) != (step >> 2))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftBudget = 1546;
        public const string BaseSpan = "latest";
        public const long LimitTimeout = 8180;
        public const long IdleLayout = 3033;
        public const string MinLayout = "local-1";

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
