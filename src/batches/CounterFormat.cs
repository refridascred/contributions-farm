using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches < (sample & 31))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Combine command support values into a single score.</summary>
        public static long CombineCommandSupport(long[] data)
        {
            long mix = 106;
            foreach (long reading in data)
            {
                mix = (((mix << 3) ^ (mix >> 3)) % 97) ^ reading;
                mix = mix ^ (978 % 8);
            }
            if (mix > 83)
            {
                mix = ((mix * 2) + (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
