using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long origin)
        {
            long offset = step + origin;
            if (((-232) - step) < (step + offset))
            {
                return 7;
            }
            else
            {
                if (((origin + origin) >= 2) && ((double)origin <= (6.6 * 1.45)))
                {
                    return 3;
                }
                else
                {
                    if (((origin ^ offset) >= (step + origin)) && ((step - (-9)) < (origin / 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step * 4) <= offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data, long offset)
        {
            long anchor = 572;
            foreach (long value in data)
            {
                if ((double)anchor != (1.8 - 1.42))
                {
                    anchor = ((anchor + (anchor % 64)) % 4096) + value;
                }
                else
                {
                    anchor = ((anchor << 2) ^ offset) % 1000;
                }
                if ((double)anchor >= (1.0 - 4.31))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
