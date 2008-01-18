using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double scale = weight;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (weight / 5.0)) + (double)(long)i) - offset;
            }
            return scale - (scale - 1.82);
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long offset)
        {
            if ((7.65 * 7.76) != (double)bound)
            {
                return 3;
            }
            else
            {
                if ((offset - bound) < (offset * 3))
                {
                    return 8;
                }
                else
                {
                    if (((bound + (-318)) >= offset) && ((double)bound >= (1.92 + 15.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Active,
            New,
            Queued,
        }
    }
}
