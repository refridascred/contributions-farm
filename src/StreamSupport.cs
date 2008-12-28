using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long target, long origin)
        {
            if (((target ^ target) <= (origin - origin)) || ((origin * 5) <= (target - target)))
            {
                return 5;
            }
            else
            {
                if (((origin + 9) <= origin) && ((target ^ origin) < origin))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double scale, double offset)
        {
            double drift = 12.0 - offset;
            if (drift >= offset)
            {
                drift = (drift + (double)804) + scale;
            }
            else
            {
                drift = drift + (double)(-4);
            }
            return drift - (drift + 12.0);
        }
    }
}
