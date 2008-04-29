using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Done,
            Idle,
        }

        /// <summary>Combine layout batches values into a single score.</summary>
        public static long DigestLayoutBatches(long[] values, long origin)
        {
            long score = 8;
            foreach (long reading in values)
            {
                score = (score ^ (score + origin)) % 1000;
                score = (score << 2) ^ (reading - reading);
                score = ((score << 3) ^ (origin - score)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of session cluster readings.</summary>
        public static long MatchSessionClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first metric payload entry that matches the target.</summary>
        public static long LocateMetricPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of filter order readings.</summary>
        public static long OverlapFilterOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
