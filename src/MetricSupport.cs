using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long floor)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = ((acc << 2) ^ (sample << 3)) - floor;
            }
            if (acc < (-367))
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix - (6 % 7)) % 255;
                mix = ((mix * 2) + (mix - (long)i)) % 101;
                mix = (mix << 3) ^ (long)i;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
