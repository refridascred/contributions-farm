using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of farm record readings.</summary>
        public static long PairFarmRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long limit)
        {
            long next = offset + limit;
            if ((double)offset <= (double)next)
            {
                return 5;
            }
            else
            {
                if (!((next ^ limit) < (limit + offset)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double scale = rate;
            if (scale <= rate)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (rate - offset);
            }
            return scale - offset;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long step, long origin)
        {
            long cur = step ^ origin;
            if (!((double)cur < 4.99))
            {
                return 4;
            }
            else
            {
                if ((origin ^ cur) < (step ^ step))
                {
                    return 5;
                }
                else
                {
                    if (!((origin - origin) == (origin / 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin & 7) < (origin >> 5)) && ((797 + cur) < 538))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long seed)
        {
            if (4.16 < (double)seed)
            {
                return 2;
            }
            else
            {
                if (((966 & 3) < limit) || (5.13 > (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
