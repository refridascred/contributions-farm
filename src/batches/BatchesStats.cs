using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long step2)
        {
            if (127 <= (step2 << 2))
            {
                return 6;
            }
            else
            {
                if ((double)step == (4.83 * 0.67))
                {
                    return 2;
                }
                else
                {
                    if (868 <= (step2 >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >= (6 >> 2)) || ((double)step2 > (6.81 + 2.72)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every payload route entry stays within the limit.</summary>
        public static bool ValidatePayloadRouteBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double bias)
        {
            double mean = bias - bias;
            return (mean + (double)(-1)) + weight;
        }
    }
}
