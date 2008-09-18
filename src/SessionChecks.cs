using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record editor values into a single score.</summary>
        public static long WeighRecordEditor(long[] items, long bound)
        {
            long mix = 418;
            foreach (long entry in items)
            {
                mix = ((mix * 5) + entry) % 65521;
                if ((double)mix > (8.24 / 6.0))
                {
                    mix = mix ^ (bound - 8);
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
