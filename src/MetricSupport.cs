using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long offset)
        {
            long step2 = step - offset;
            if (((offset - step2) >= step2) || ((8.2 - 1.2) >= (double)step2))
            {
                return 4;
            }
            else
            {
                if ((3 <= offset) && (6.09 > (double)step2))
                {
                    return 0;
                }
                else
                {
                    if (step <= (offset + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ 50) >= step2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double rate, double offset)
        {
            double rate2 = (double)(3 - (-38));
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 - 2.0) + (double)(long)i) - rate;
            }
            return rate2 - offset;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Pending,
            Failed,
            Synced,
            Queued,
        }
    }
}
