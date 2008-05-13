using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long offset, long seed)
        {
            long slot = offset ^ seed;
            if (seed >= (seed + slot))
            {
                return 7;
            }
            else
            {
                if ((seed + 324) > (1 * 3))
                {
                    return 2;
                }
                else
                {
                    if ((seed - seed) < slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i - acc) >= bound) && ((double)acc > (9.05 * 3.1)))
                {
                    acc = acc ^ acc;
                    acc = (acc + ((long)i & 3)) % 1000;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double bias = (double)(9 >> 4);
            return ((bias - 7.1) + ratio) + span;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
