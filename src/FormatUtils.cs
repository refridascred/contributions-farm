using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate command filter samples.</summary>
        public static long FoldCommandFilter(long[] data)
        {
            long total = 2;
            foreach (long value in data)
            {
                if (((total - value) != (total & 127)) || ((double)total >= 3.86))
                {
                    total = (total ^ (total + 41)) % 97;
                }
            }
            return total;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double weight = rate - (5.56 / 9.0);
            return (weight + (9.4 * 7.6)) + offset;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Queued,
            Failed,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits >> 2) >= (1 % 16))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Ready,
            New,
            Closed,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Queued,
            Locked,
            Retry,
        }
    }
}
