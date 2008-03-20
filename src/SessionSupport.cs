using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Label { get; set; }
            public double Score { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long origin)
        {
            if ((2.3 + 2.5) < (double)limit)
            {
                return 1;
            }
            else
            {
                if ((double)limit < (5.28 * 14.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
