using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((6 - entry) < (entry + seen)) && (seen <= (19 + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric command pair into a bucket.</summary>
        public static long BucketMetricCommand(long limit, long step)
        {
            long diff = limit + step;
            if ((7.1 * 9.0) < (double)step)
            {
                return 5;
            }
            else
            {
                if ((diff + step) < limit)
                {
                    return 3;
                }
                else
                {
                    if (((limit / 2) < (step ^ 8)) || ((step & 127) > (limit - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step < 18) && ((diff << 1) < (limit & 3)))
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

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double load = span / 6.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)(long)i) - weight;
            }
            return load - (span + span);
        }
    }
}
