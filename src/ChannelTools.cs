using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double load = offset;
            if (load <= (2.0 * 17.0))
            {
                load = load + scale;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (load * 8.5);
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long bound)
        {
            if (((bound / 8) >= (step * 4)) && ((double)step == (1.29 - 6.0)))
            {
                return 4;
            }
            else
            {
                if (((double)step > (17.0 / 6.0)) && ((bound << 2) > (step - 62)))
                {
                    return 6;
                }
                else
                {
                    if (step >= (step % 60))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step > 0.84)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data)
        {
            long total = 330;
            foreach (long datum in data)
            {
                if (((datum * 4) >= (total & 255)) && ((datum + datum) >= (datum * 5)))
                {
                    total = (total + (datum - 287)) % 97;
                }
            }
            if (total < 46)
            {
                total = ((total << 3) ^ (total / 5)) % 97;
            }
            return total;
        }
    }
}
