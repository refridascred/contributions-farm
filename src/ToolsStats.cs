using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Retry,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double weight = (double)(2 - (-162));
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + floor) + (double)(long)i) - ratio;
            }
            return weight - 1.06;
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long CountBufferEditorHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value == (3.0 / 5.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate counter filter readings against a bound.</summary>
        public static bool GuardCounterFilterLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
