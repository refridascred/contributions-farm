using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Measure how many context buffer samples are out of range.</summary>
        public static long AuditContextBufferOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits << 2) <= (reading ^ reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + 928) == (sample + origin))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every channel buffer entry stays within the limit.</summary>
        public static bool GuardChannelBufferLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many channel tools samples are out of range.</summary>
        public static long MeasureChannelToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)seen != (2.51 * 9.71))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
