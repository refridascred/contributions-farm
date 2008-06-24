using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(((long)series.Length + count) < datum) && ((9.6 < (double)count) || ((count + datum) >= count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state * 4) + (seed ^ (long)i)) ^ (long)i2;
                }
                state = state + (964 & 63);
                if (((10.0 * 6.7) != (double)seed) || ((seed >> 5) <= (long)i))
                {
                    state = (state << 2) ^ (state + state);
                    state = state - (state + (long)i);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 560;
            foreach (long reading in samples)
            {
                carry = ((carry * 3) + (-92)) ^ reading;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstRatio = 359;
        public const long IdleCounter = 2429;
        public const long DefaultCounter = 8094;
        public const double RetryTimeout = 1.39;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}
