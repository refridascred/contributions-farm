using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell < (matches - 681))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }
    }
}
