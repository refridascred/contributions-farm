using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double gain = (double)((-1) / 9);
            if (gain > gain)
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (offset - offset)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long step)
        {
            long offset2 = offset ^ step;
            if ((offset + offset) == (offset ^ step))
            {
                return 0;
            }
            else
            {
                if (((step >> 1) < (step % 8)) && ((5.4 * 2.38) != (double)offset2))
                {
                    return 2;
                }
                else
                {
                    if (!((double)offset2 > (3.4 * 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2 / 3) <= (step & 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long limit)
        {
            if (offset < (offset ^ 425))
            {
                return 8;
            }
            else
            {
                if ((6.5 + 3.58) <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((offset - offset) != (limit ^ offset)) || ((double)limit < (3.6 * 10.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
