using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long step, long floor)
        {
            if (((floor + step) <= (floor << 2)) && (step > (step + floor)))
            {
                return 0;
            }
            else
            {
                if ((floor >> 4) < step)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Ready,
            New,
            Queued,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mark = 2;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (mark * 4) + (long)i;
                    mark = mark ^ mark;
                }
                mark = mark ^ (cell % 3);
                if ((mark >> 3) <= (88 + cell))
                {
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = (mark * 5) + mark;
                }
            }
            return mark % 4096;
        }
    }
}
