using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading >> 5) != (seen - floor))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc << 3) ^ (long)i) % 4096;
                    acc = (acc - ((long)i2 & 3)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double span)
        {
            double load = span / 9.0;
            if (load >= span)
            {
                load = (load - (load / 8.0)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 3.86) + (double)(long)i;
            }
            return load + (span * 2.39);
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
