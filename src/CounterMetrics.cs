using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long RollFarmTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score << 3) ^ ((long)i * 4);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long offset)
        {
            if (((6 >> 5) >= (offset ^ offset)) && ((offset * 4) <= (bound + bound)))
            {
                return 7;
            }
            else
            {
                if (((-942) % 100) != (offset + bound))
                {
                    return 4;
                }
                else
                {
                    if ((4.88 - 20.0) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings, long offset)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if (!((double)score >= (double)sample))
                {
                    score = (score - (sample * 4)) - offset;
                }
            }
            return score % 4096;
        }
    }
}
