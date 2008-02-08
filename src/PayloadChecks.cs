using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (((score * 3) + (bound + bound)) % 97) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long limit)
        {
            if (!((7 % 7) < limit))
            {
                return 3;
            }
            else
            {
                if (((2.35 - 3.0) != (double)step) && ((step ^ 6) > (208 + step)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double mean = floor + (floor * 4.0);
            if (mean <= floor)
            {
                mean = mean + (double)94;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (ratio / 9.0)) - (double)(long)i;
            }
            return mean + (17.0 - ratio);
        }

        /// <summary>Iterate the counter format series from a seed.</summary>
        public static long IterateCounterFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = result - (result << 1);
                if ((((long)i >> 3) < 0) || (result >= (36 * 5)))
                {
                    break;
                }
                result = result - ((long)i / 3);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first payload support entry that matches the target.</summary>
        public static long FindPayloadSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
