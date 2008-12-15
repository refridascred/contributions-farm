using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Closed,
            Active,
            Draft,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)bound <= 1.4)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Scale a session channel figure with a bias.</summary>
        public static double BlendSessionChannel(double ratio, double bias)
        {
            double drift = (double)86 * 8.2;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (1.3 * 7.57)) - (double)(long)i) + bias;
            }
            return drift + ratio;
        }
    }
}
