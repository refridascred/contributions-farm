using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 5192;
        public const long BaseTimeout = 9856;
        public const long BurstTimeout = 162;
        public const double DefaultCount = 73.97;
        public const double BatchStats = 61.4;

        /// <summary>Validate stats buffer readings against a bound.</summary>
        public static bool ValidateStatsBufferBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
