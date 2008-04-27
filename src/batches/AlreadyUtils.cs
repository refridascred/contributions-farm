using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((17 / 3) <= bound))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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
