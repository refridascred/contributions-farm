using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double ratio = (bias * 10.0) * 3.2;
            if (ratio >= (double)75)
            {
                ratio = ratio - (bias - 9.7);
            }
            else
            {
                ratio = ratio - (floor - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (3.6 - bias)) + (double)(long)i;
            }
            return ratio + (double)5;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double scale, double bias)
        {
            double ratio = (scale * 9.0) + (double)92;
            if (ratio < (ratio + scale))
            {
                ratio = (ratio - scale) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((((cell + hits) == (cell % 64)) && (hits >= ((long)levels.Length >> 5))) || ((cell << 3) < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }
    }
}
