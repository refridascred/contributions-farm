using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((double)(long)samples.Length != (8.64 * 6.56)) || ((825 ^ reading) < limit)) && !(16.0 <= (double)limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Count stats tools pairs that satisfy a relation.</summary>
        public static long PairStatsToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
