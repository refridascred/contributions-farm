using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                if (((double)score < (2.76 + 0.32)) && ((double)score > (double)step))
                {
                    score = ((score << 3) ^ (step + step)) % 4096;
                    score = ((score << 2) ^ (score << 3)) % 101;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a schema window counter forward.</summary>
        public static long StepSchemaWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 3) ^ score) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 2550;
        public const string MinBatch = "fallback-edge";
        public const long CacheBatch = 6688;
        public const long StepBatch = 9443;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits == (6.0 * 3.24))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
