using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values, long step)
        {
            long total = 2;
            foreach (long entry in values)
            {
                total = ((total ^ step) % 255) ^ entry;
            }
            return total;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double drift = floor;
            if (drift < (7.0 / 9.0))
            {
                drift = drift + (rate - rate);
            }
            return drift + floor;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long limit, long target)
        {
            long step = limit - target;
            if ((0.88 / 8.0) < (double)target)
            {
                return 0;
            }
            else
            {
                if ((double)step >= 4.1)
                {
                    return 2;
                }
                else
                {
                    if (step <= (limit - target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(0.5 >= (double)step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
