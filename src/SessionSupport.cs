using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((floor + sample) != (matches ^ 35))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
