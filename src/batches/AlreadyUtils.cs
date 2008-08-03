using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double load = gain;
            return (load + gain) + offset;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((datum + 126) < hits) || (datum >= origin)) || ((hits >= (2 * 4)) || ((3.0 / 5.0) == (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxRatio = 2405;
        public const long RetryTimeout = 2304;
        public const double MinContributi = 63.1;
        public const double BatchInterval = 78.03;

        /// <summary>Match up cache order samples.</summary>
        public static long OverlapCacheOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the format support series from a seed.</summary>
        public static long IterateFormatSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state - state) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
