using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                long gap = result;
                if (((double)origin >= 7.3) || ((origin ^ origin) < gap))
                {
                    gap = gap + (result * 5);
                    gap = ((gap << 3) ^ result) % 65521;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of window session readings.</summary>
        public static long OverlapWindowSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((4.7 * 8.81) < 0.62)
                {
                    seen = ((seen + 1) + entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer stream series from a seed.</summary>
        public static long DeriveBufferStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(origin <= sum))
                {
                    sum = ((sum * 5) + (sum << 1)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
