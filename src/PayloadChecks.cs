using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor / 3) != ((-2) - floor))
                {
                    mix = (mix ^ (mix + floor)) % 101;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account checks entries that pass the check.</summary>
        public static long MeasureAccountChecksHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) >= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
