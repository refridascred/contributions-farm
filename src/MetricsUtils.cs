using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double drift = 19.0;
            if (drift < offset)
            {
                drift = drift + (double)918;
            }
            return drift + scale;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series)
        {
            long total = 74;
            foreach (long cell in series)
            {
                total = (total + (cell - total)) % 255;
                total = (total << 2) ^ (total << 2);
            }
            if (total > 558)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long origin)
        {
            if ((seed + seed) <= origin)
            {
                return 7;
            }
            else
            {
                if ((seed * 5) <= seed)
                {
                    return 3;
                }
                else
                {
                    if ((origin * 3) <= (seed % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((333 - seed) == (seed + origin)) && (995 < (seed ^ origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Closed,
            Ready,
            Pending,
        }
    }
}
