using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen >= (seen / 8))
                {
                    seen = ((seen + 2) ^ reading) + origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry profile samples.</summary>
        public static long WeighEntryProfile(long[] samples)
        {
            long mark = 394;
            foreach (long item in samples)
            {
                if ((item + item) >= (83 >> 2))
                {
                    mark = mark + mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
