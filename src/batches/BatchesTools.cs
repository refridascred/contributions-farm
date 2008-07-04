using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)(long)i) - bias2;
            }
            return rate - (bias / 4.0);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long seed, long target)
        {
            if ((target ^ 696) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed > 48) || ((target & 63) != (seed ^ seed)))
                {
                    return 7;
                }
                else
                {
                    if ((8.9 / 4.0) != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
