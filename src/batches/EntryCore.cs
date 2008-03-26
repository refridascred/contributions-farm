using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double drift = (double)41 - (double)4;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + offset) - (double)(long)i;
            }
            return drift + (scale - drift);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 8713;
        public const double WindowTimeout = 63.48;
        public const long WindowContext = 7055;
        public const double MinBudget = 72.25;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items)
        {
            long state = 4;
            foreach (long entry in items)
            {
                if ((state + state) >= (98 % 16))
                {
                    state = ((state * 2) + (entry % 12)) % 255;
                }
                if (((double)191 == (double)state) && ((state % 3) < entry))
                {
                    state = state ^ (entry + state);
                }
            }
            return state;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
