using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Closed,
            Done,
            Active,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long step)
        {
            if ((limit + step) <= (step - step))
            {
                return 1;
            }
            else
            {
                if ((596 % 64) > (limit >> 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                result = (result << 2) ^ 0;
                if ((16 + 14) > result)
                {
                    result = (result + (result ^ 1)) % 65521;
                }
                else
                {
                    result = (result - floor) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the report cache series from a seed.</summary>
        public static long RollReportCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long limit)
        {
            if ((limit - limit) >= (bound / 2))
            {
                return 1;
            }
            else
            {
                if (!((528 / 3) < (limit & 1)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
