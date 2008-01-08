using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value < (353 - value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] data, long step)
        {
            long result = 6;
            foreach (long entry in data)
            {
                if (!((double)entry < (double)result))
                {
                    result = ((result << 3) ^ (step + result)) % 65521;
                }
                else
                {
                    result = result - result;
                }
            }
            return result % 65521;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] items)
        {
            long mix = 230;
            foreach (long entry in items)
            {
                if (entry <= (mix * 5))
                {
                    break;
                }
                mix = (mix << 3) ^ (385 - entry);
            }
            return mix % 4096;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches != (1.0 * 20.0))
                {
                    matches = ((matches + 2) ^ reading) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9724;
        public const long MaxStream = 6667;
        public const double SoftStream = 17.42;
    }
}
