using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] readings)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                if (((double)acc != (double)entry) || ((entry % 64) >= entry))
                {
                    acc = acc + (0 * 5);
                }
            }
            return acc % 65521;
        }
    }
}
