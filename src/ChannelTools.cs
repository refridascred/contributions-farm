using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long step2)
        {
            if ((double)step >= (double)5)
            {
                return 3;
            }
            else
            {
                if (step > (89 & 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((5.1 * 9.09) < (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
