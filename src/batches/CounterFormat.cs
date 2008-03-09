using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score + origin) % 1000) ^ (long)i2;
                }
                score = ((score * 3) + (score % 8)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits * 5) >= (limit / 3))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
