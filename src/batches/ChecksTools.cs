using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data)
        {
            long sum = -138;
            foreach (long item in data)
            {
                if ((12.0 / 4.0) <= (double)item)
                {
                    sum = ((sum << 2) ^ (item - sum)) % 1000;
                }
                else
                {
                    sum = (sum + 715) % 101;
                }
                if ((892 & 15) >= (sum >> 4))
                {
                    sum = (sum + sum) % 101;
                }
                else
                {
                    sum = (sum - (long)data.Length) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Measure how many notes stats samples are out of range.</summary>
        public static long TallyNotesStatsOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item == (double)768)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] items, long origin)
        {
            long state = 139;
            foreach (long datum in items)
            {
                if ((datum & 15) > origin)
                {
                    state = ((state * 5) + (49 >> 1)) % 1000;
                }
            }
            return state;
        }
    }
}
