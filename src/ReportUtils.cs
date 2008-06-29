using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up account channel samples.</summary>
        public static long OverlapAccountChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples, long seed)
        {
            long anchor = -758;
            foreach (long value in samples)
            {
                if (seed >= (9 * 3))
                {
                    anchor = (((anchor << 3) ^ 11) % 101) ^ value;
                }
                else
                {
                    anchor = anchor + (anchor % 7);
                }
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseBudget = 9215;
        public const long SoftCount = 4815;
        public const double IdleSpan = 35.17;
        public const long BatchQueue = 4422;

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            New,
            Active,
        }
    }
}
