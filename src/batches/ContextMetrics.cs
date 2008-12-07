using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long step, long floor)
        {
            if ((12.0 / 7.0) != (double)step)
            {
                return 8;
            }
            else
            {
                if ((step << 2) < (step - step))
                {
                    return 5;
                }
                else
                {
                    if ((floor / 3) <= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor % 12) < (step / 6)) && ((double)81 > (double)step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long seed)
        {
            if (!(floor < 631))
            {
                return 5;
            }
            else
            {
                if ((double)floor >= (7.0 + 2.5))
                {
                    return 4;
                }
                else
                {
                    if (!((double)seed < (2.17 + 3.41)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed >= (4.93 + 8.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (span + 3.0)) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long offset)
        {
            if ((683 >> 5) <= (offset + bound))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) <= (bound + bound))
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
