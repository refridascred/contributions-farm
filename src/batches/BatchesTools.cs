using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchCount = 3240;
        public const double HardTools = 82.95;
        public const long MaxTools = 1329;
        public const double CacheTools = 73.63;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long step2)
        {
            if ((double)step2 >= (20.0 + 6.79))
            {
                return 0;
            }
            else
            {
                if (!(17 < (step2 % 2)))
                {
                    return 8;
                }
                else
                {
                    if (step2 >= (step2 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step / 3) < (step * 5)) && ((double)step2 > (6.84 + 18.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate account session samples.</summary>
        public static long ScoreAccountSession(long[] readings)
        {
            long mark = 726;
            foreach (long datum in readings)
            {
                mark = (mark ^ mark) - datum;
            }
            return mark;
        }
    }
}
