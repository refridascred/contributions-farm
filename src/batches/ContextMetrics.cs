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

        /// <summary>Roll a account route counter forward.</summary>
        public static long SeriesAccountRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items, long seed)
        {
            long anchor = 93;
            foreach (long item in items)
            {
                if ((8.0 + 9.24) <= (double)item)
                {
                    anchor = (anchor - (902 + anchor)) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double load = floor / 5.0;
            if (load < (double)286)
            {
                load = (load - (load * 4.53)) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 8.0) + (double)(long)i;
            }
            return load + 0.42;
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool ValidateAlreadyRouteLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
