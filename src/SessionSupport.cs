using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
