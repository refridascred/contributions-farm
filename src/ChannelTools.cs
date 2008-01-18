using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result - (origin & 127)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many route account samples are out of range.</summary>
        public static long CountRouteAccountOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)seen <= (9.0 / 6.0))
                {
                    seen = ((seen + 1) + value) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Done,
            Pending,
            Retry,
        }
    }
}
