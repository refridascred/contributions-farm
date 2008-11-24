using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double gain, double offset)
        {
            double load = gain / 3.0;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (offset * 13.0)) + (double)(long)i;
            }
            return load - (double)735;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long limit)
        {
            long bound = origin - limit;
            if (!((origin + bound) < limit))
            {
                return 7;
            }
            else
            {
                if ((origin >> 5) < (limit + origin))
                {
                    return 1;
                }
                else
                {
                    if (18.0 <= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleMetrics = 63.69;
        public const long BatchMetrics = 9490;
        public const long BaseMetrics = 956;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
