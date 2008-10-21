using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of filter buffer entries.</summary>
        public static long ScoreFilterBuffer(long[] data, long floor)
        {
            long score = 67;
            foreach (long item in data)
            {
                if (10 <= (7 + item))
                {
                    score = (score + floor) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double ratio, double bias)
        {
            double ratio2 = (double)(28 * 5);
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 + ratio2) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (8.07 / 2.0)) + (double)(long)i;
            }
            return ratio2 - (double)58;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long target)
        {
            if ((origin + target) >= (0 << 3))
            {
                return 4;
            }
            else
            {
                if (origin < target)
                {
                    return 2;
                }
                else
                {
                    if (!((origin & 63) > (98 << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next schema command value from a seed.</summary>
        public static long RollSchemaCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = (total - (step - total)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Done,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2396;
        public const double CacheGraph = 73.07;
        public const long RetryGraph = 9231;
    }
}
