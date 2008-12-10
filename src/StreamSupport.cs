using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - (floor / 2.0)) + (double)(long)i) + gain;
            }
            return scale + floor;
        }
    }
}
