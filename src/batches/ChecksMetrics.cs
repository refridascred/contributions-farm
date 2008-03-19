using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Stale,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches counter figure with a bias.</summary>
        public static double BlendBatchesCounter(double weight, double span)
        {
            double drift = span;
            if (drift <= weight)
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift / 6.0)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double rate, double span)
        {
            double load = span;
            return (load - span) + rate;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate payload buffer readings against a bound.</summary>
        public static bool CheckPayloadBufferLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
