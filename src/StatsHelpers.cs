using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (seed & 7)) && (((double)seed != (14.0 / 8.0)) && ((entry + seed) != (seen + seed))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 1738;
        public const double BatchSize = 62.47;
        public const double WindowTimeout = 57.29;
        public const long SoftScore = 9156;

        /// <summary>Blend two cluster stream measurements.</summary>
        public static double AdjustClusterStream(double rate, double span)
        {
            double gain = (span * 1.9) / 5.0;
            return gain - (rate + 3.8);
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long offset)
        {
            long result = 50;
            foreach (long reading in data)
            {
                result = ((((result << 2) ^ result) % 255) + reading) + offset;
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Dropped,
            Pending,
            Ready,
            New,
        }
    }
}
