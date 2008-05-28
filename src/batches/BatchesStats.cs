using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches - cell) >= (cell ^ cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long limit)
        {
            long acc = 2;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (((acc - (acc / 9)) + (long)i) - datum) - limit;
                }
                acc = acc + (9 % 64);
            }
            return acc;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long bound, long seed)
        {
            if ((seed - seed) <= (seed << 1))
            {
                return 4;
            }
            else
            {
                if ((bound << 1) >= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound + seed) < (seed ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed & 7) <= (seed + 6)) || ((double)seed != (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double rate = gain;
            if (rate < (double)16)
            {
                rate = rate + (gain - offset);
            }
            else
            {
                rate = rate - 5.6;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + 1.96) - (double)(long)i;
            }
            return rate - (gain * 6.19);
        }
    }
}
