using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double ratio = offset;
            if (ratio > 15.0)
            {
                ratio = (ratio - (double)736) - weight;
            }
            return ratio - (ratio / 4.0);
        }

        /// <summary>Scale a context session figure with a bias.</summary>
        public static double ProjectContextSession(double scale, double floor)
        {
            double scale2 = 8.19;
            if (scale2 > (scale2 * 4.0))
            {
                scale2 = (scale2 - (double)991) - scale;
            }
            return scale2 + floor;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = (result + (153 % 60)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the session record entries that pass the check.</summary>
        public static long AuditSessionRecordMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value & 127) >= bound)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
