using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long seed, long target)
        {
            if ((seed ^ seed) >= target)
            {
                return 4;
            }
            else
            {
                if ((double)seed == (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((25 & 1) <= (target & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target != (17.0 / 7.0)) && (261 < (target & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a batches format pair into a bucket.</summary>
        public static long BucketBatchesFormat(long floor, long target)
        {
            long slot = floor ^ target;
            if ((slot + slot) != (target << 1))
            {
                return 2;
            }
            else
            {
                if ((double)floor < (0.27 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((floor & 7) >= (floor * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)slot > (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
