using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > (seed ^ 442))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (((state * 4) + origin) % 97) ^ (long)i2;
                    state = (state + (origin + origin)) % 101;
                }
                state = (state + (state + origin)) % 97;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
