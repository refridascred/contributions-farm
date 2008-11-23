using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3253;
        public const string WindowFarm = "open-1";
        public const double DefaultFarm = 7.21;
        public const long LimitWidth = 3944;

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long target)
        {
            long state = 89;
            foreach (long sample in series)
            {
                if (!((3 & 15) == (sample * 4)))
                {
                    state = ((state ^ (346 + state)) % 65521) - target;
                }
            }
            if (state < (-9))
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long floor)
        {
            long total = -88;
            foreach (long reading in readings)
            {
                if (((reading + 341) == (773 / 3)) && ((double)floor <= 8.4))
                {
                    continue;
                }
                if (!((11.0 * 2.32) <= (7.09 - 19.0)))
                {
                    total = (total ^ (floor << 2)) % 1000;
                    total = (total + (floor + (long)readings.Length)) % 101;
                }
                total = total ^ total;
            }
            return total % 65521;
        }
    }
}
