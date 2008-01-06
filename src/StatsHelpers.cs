using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a context stream reading.</summary>
        public static double ProjectContextStream(double ratio, double span)
        {
            double ratio2 = 2.3 - span;
            if (ratio2 < (double)510)
            {
                ratio2 = ratio2 - ratio;
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 - (ratio / 7.0);
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen & 127) < seen) || ((3.0 / 3.0) <= (double)value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
