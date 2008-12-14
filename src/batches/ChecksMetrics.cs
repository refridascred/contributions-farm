using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + offset) + (double)(long)i) + gain;
            }
            return weight - (offset / 2.0);
        }

        /// <summary>Audit batches filter readings against a rule.</summary>
        public static long CountBatchesFilterHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (377 > (hits - hits))
                {
                    hits = ((hits + 1) - sample) - seed;
                }
            }
            return hits;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double bias)
        {
            double rate = weight / 9.0;
            if (rate > (rate / 6.0))
            {
                rate = (rate + 3.0) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (double)9;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long offset)
        {
            if ((limit ^ 231) != (offset ^ offset))
            {
                return 2;
            }
            else
            {
                if (447 > (limit + limit))
                {
                    return 6;
                }
                else
                {
                    if (!((limit & 127) > (limit - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset & 15) > (offset << 1)) || ((limit + offset) <= (offset / 5)))
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

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
