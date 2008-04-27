using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long state = 924;
            foreach (long entry in data)
            {
                state = (((state << 2) ^ (844 / 5)) % 255) - entry;
                if ((state <= (state >> 5)) || ((state << 3) >= (state - state)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 5541;
        public const double DefaultRecord = 54.84;
        public const long StepRatio = 5785;
        public const long SoftRecord = 5081;
        public const double WindowRecord = 73.24;

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 8120;
        public const double HardLevel = 69.73;
        public const long SoftStream = 7567;
        public const long WindowStream = 4102;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
