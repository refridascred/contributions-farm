using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double drift = gain / 8.0;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)3) - (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long offset, long limit)
        {
            long edge = offset + limit;
            if (offset > (offset - edge))
            {
                return 1;
            }
            else
            {
                if ((2.38 - 3.5) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((8.04 + 1.7) >= (double)edge)
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

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryScore = 5077;
        public const long MaxInterval = 9100;
        public const string StepCommits = "local-edge";
        public const long LimitLevel = 8941;
        public const long WindowCommits = 9356;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
