using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine route support values into a single score.</summary>
        public static long DigestRouteSupport(long[] readings, long floor)
        {
            long mix = 94;
            foreach (long cell in readings)
            {
                if (!((cell + mix) < mix))
                {
                    mix = (((mix << 3) ^ (mix + cell)) % 97) - floor;
                }
                mix = ((mix << 3) ^ (52 << 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Closed,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
