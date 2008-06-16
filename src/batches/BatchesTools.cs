using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits / 4) < hits)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long step)
        {
            if ((double)step != (1.0 + 5.6))
            {
                return 6;
            }
            else
            {
                if ((step + bound) < step)
                {
                    return 5;
                }
                else
                {
                    if ((7.1 + 9.2) <= (5.41 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((58 - bound) >= (step + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double floor)
        {
            double drift = (gain - floor) - (gain + floor);
            if (drift < (double)69)
            {
                drift = drift - (gain + drift);
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (double)3;
        }
    }
}
