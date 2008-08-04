using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double WindowWidth = 69.17;
        public const string BatchCommand = "stable";
        public const double LimitCount = 67.15;
        public const long LimitDepth = 9327;
        public const string WindowCommand = "standard-v2";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally - item) != (item + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
