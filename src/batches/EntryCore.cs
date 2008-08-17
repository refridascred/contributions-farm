using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Active,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Locate a command record reading by value.</summary>
        public static long SeekCommandRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every channel cluster entry stays within the limit.</summary>
        public static bool ValidateChannelClusterLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next support schema value.</summary>
        public static double ScaleSupportSchema(double bias, double bias2)
        {
            double load = 7.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - (double)(long)i) + bias) - bias2;
            }
            return load + 15.0;
        }
    }
}
