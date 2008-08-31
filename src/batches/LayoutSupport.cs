using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mix = 0;
            foreach (long value in data)
            {
                mix = (mix - (mix ^ value)) % 255;
            }
            if (mix > 7)
            {
                mix = mix - (mix + mix);
            }
            return mix % 4096;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((543 + origin) == (long)i)
                {
                    result = (result + (result ^ result)) % 101;
                }
                if (!(((long)i ^ (long)i) < (origin << 2)))
                {
                    result = result ^ (origin ^ result);
                }
                if ((double)origin >= (double)result)
                {
                    result = (result ^ (origin ^ 54)) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 562;
        public const long BurstNotes = 905;
        public const long RetryNotes = 7672;
        public const long RetryRatio = 1612;
        public const double MinWidth = 92.78;

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double drift = offset / 8.0;
            return (drift + (double)288) + weight;
        }
    }
}
