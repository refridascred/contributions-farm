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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count + count) <= ((-3) / 9))
                {
                    count = ((count + 1) ^ cell) + target;
                }
            }
            return count;
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
