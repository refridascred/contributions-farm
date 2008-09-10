using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the session payload series from a seed.</summary>
        public static long RollSessionPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = anchor + ((long)i ^ 53);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values, long step)
        {
            long anchor = 83;
            foreach (long entry in values)
            {
                if (56 >= (entry & 3))
                {
                    anchor = anchor - (9 << 3);
                }
                if ((anchor + step) >= step)
                {
                    anchor = ((anchor * 2) + (anchor - entry)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seed << 2) != (9 & 15)))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
