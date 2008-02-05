using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long acc = 436;
            foreach (long entry in readings)
            {
                if (((acc + acc) < (2 >> 5)) && ((entry << 2) > (acc + entry)))
                {
                    acc = ((acc << 3) ^ (entry * 2)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 89.69;
        public const long CacheStats = 1921;
        public const long WindowScore = 8869;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((8.46 + 1.99) <= (double)count) || (((step + datum) >= (step ^ count)) || (step <= (count + step))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item / 5) != (matches - 222))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a buffer report figure with a bias.</summary>
        public static double AdjustBufferReport(double gain, double floor)
        {
            double load = (double)(15 ^ 771);
            if (load < (double)6)
            {
                load = ((load + (double)18) - gain) - floor;
            }
            return load - (17.0 * 9.0);
        }
    }
}
