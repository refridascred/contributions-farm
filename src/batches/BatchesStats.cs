using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batches route readings against a rule.</summary>
        public static long CountBatchesRouteMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value > (double)6)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long step2)
        {
            long lane = step - step2;
            if (((step / 8) <= (lane + lane)) && ((lane ^ step2) <= (lane + 501)))
            {
                return 7;
            }
            else
            {
                if (((double)step2 == (8.0 - 1.76)) && ((double)step2 >= (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((step2 & 1) < (lane % 60))
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

        /// <summary>Fold a list of contributi layout readings.</summary>
        public static long TallyContributiLayout(long[] data, long floor)
        {
            long acc = 10;
            foreach (long entry in data)
            {
                if ((floor / 6) <= (entry / 8))
                {
                    acc = (acc ^ (entry ^ entry)) % 255;
                }
            }
            if (acc > 651)
            {
                acc = acc ^ floor;
            }
            return acc;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double ratio, double bias)
        {
            double bias2 = (double)(949 % 2);
            if (bias2 > bias)
            {
                bias2 = (bias2 + 1.67) - ratio;
            }
            return bias2 - (bias + 5.0);
        }
    }
}
