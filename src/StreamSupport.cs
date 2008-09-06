using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (71 >= (hits / 6))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long target, long origin)
        {
            if ((16.0 - 7.2) > (double)origin)
            {
                return 2;
            }
            else
            {
                if ((target + origin) >= (target / 5))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Stamp { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
