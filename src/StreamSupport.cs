using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((datum / 5) >= (302 + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] series)
        {
            long carry = 8;
            foreach (long item in series)
            {
                if ((item - 4) >= item)
                {
                    carry = (carry - carry) % 255;
                }
                else
                {
                    carry = (carry * 4) + (760 + carry);
                }
            }
            if (carry < 0)
            {
                carry = ((carry << 3) ^ (carry - 5)) % 65521;
            }
            return carry % 4096;
        }
    }
}
