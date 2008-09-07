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

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            New,
            Locked,
            Pending,
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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
