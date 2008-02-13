using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long step)
        {
            if (target <= 2)
            {
                return 5;
            }
            else
            {
                if (!((step << 3) >= (3 + step)))
                {
                    return 6;
                }
                else
                {
                    if (4.0 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < (step + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double span)
        {
            double scale = (span / 4.0) + (span + span);
            if (scale < (double)988)
            {
                scale = scale + (span - 12.0);
            }
            else
            {
                scale = scale + weight;
            }
            return scale + (double)72;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long target)
        {
            if ((target - step) == (step / 4))
            {
                return 7;
            }
            else
            {
                if (!((step + target) != (step * 3)))
                {
                    return 2;
                }
                else
                {
                    if (((420 + step) < (-9)) && (step >= (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 4) < (step - step))
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
        }
    }
}
