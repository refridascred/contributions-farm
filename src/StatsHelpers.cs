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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double floor)
        {
            double gain = (1.0 / 2.0) + floor;
            if (gain < (double)67)
            {
                gain = gain - (double)95;
            }
            else
            {
                gain = gain - (weight - gain);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + (gain * 0.04);
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
