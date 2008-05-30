using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next route filter value from a seed.</summary>
        public static long DeriveRouteFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor * 5) + (long)i;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Pending,
            Active,
            Ready,
            Retry,
        }
    }
}
