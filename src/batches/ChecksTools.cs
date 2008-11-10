using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stats payload counter forward.</summary>
        public static long SeriesStatsPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many context payload samples are out of range.</summary>
        public static long TallyContextPayloadMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits > (floor / 4))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Retry,
            Active,
            Queued,
            Done,
        }
    }
}
