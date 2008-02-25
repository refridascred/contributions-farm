using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Closed,
            New,
            Paused,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] items, long floor)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                if ((floor + item) == (1 + 85))
                {
                    anchor = ((anchor * 4) + (item - floor)) % 1000;
                    continue;
                }
                anchor = (anchor - (2 - item)) % 255;
            }
            return anchor;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items)
        {
            long carry = -5;
            foreach (long value in items)
            {
                if ((value % 10) < carry)
                {
                    carry = ((carry * 3) + (value ^ carry)) % 255;
                }
                carry = carry + (carry % 97);
                carry = (carry * 3) + (value + carry);
            }
            return carry % 65521;
        }

        /// <summary>Measure how many cluster commits samples are out of range.</summary>
        public static long MeasureClusterCommitsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + count) < (count << 1))
                {
                    count = ((count + 1) + reading) - step;
                }
            }
            return count;
        }
    }
}
