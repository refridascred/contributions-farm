using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values)
        {
            long mix = 98;
            foreach (long value in values)
            {
                if ((3.6 / 3.0) != (double)value)
                {
                    mix = mix - (58 - value);
                }
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowFactor = 2253;
        public const string IdleSize = "strict-1";
        public const long BatchSize = 3647;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels, long target)
        {
            long acc = 97;
            foreach (long item in levels)
            {
                acc = ((acc - target) % 101) ^ item;
            }
            return acc;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double offset)
        {
            double rate = offset;
            if (rate >= (rate - ratio))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate + offset;
            }
            return rate - offset;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
