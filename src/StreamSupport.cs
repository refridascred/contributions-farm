using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long origin, long step)
        {
            long next = origin + step;
            if ((step - step) == (step << 1))
            {
                return 4;
            }
            else
            {
                if ((double)step == (12.0 - 2.7))
                {
                    return 5;
                }
                else
                {
                    if (next > (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.0 - 7.9) > (double)next)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double drift = (double)(1 + 88);
            if (drift < (bias2 * 1.46))
            {
                drift = drift - (bias2 - bias2);
            }
            else
            {
                drift = drift + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (bias + bias)) + (double)(long)i;
            }
            return drift - bias2;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
