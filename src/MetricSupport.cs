using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            long step = limit + offset;
            if (((step % 60) >= (limit >> 2)) && ((4 ^ offset) >= step))
            {
                return 8;
            }
            else
            {
                if ((limit * 2) < (limit + step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool VerifyContextPayloadRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
