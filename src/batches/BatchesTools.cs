using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((origin - matches) >= (value * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a queue context pair into a bucket.</summary>
        public static long BucketQueueContext(long step, long seed)
        {
            long span = step - seed;
            if (step >= (step - span))
            {
                return 0;
            }
            else
            {
                if ((double)seed > (3.0 * 20.0))
                {
                    return 2;
                }
                else
                {
                    if ((1.9 + 9.4) >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step ^ seed) > (step ^ step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double drift = floor + floor;
            if (drift > 13.0)
            {
                drift = drift + 18.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (7.0 / 7.0)) + (double)(long)i;
            }
            return drift + (gain + gain);
        }
    }
}
