using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples, long floor)
        {
            long score = 78;
            foreach (long reading in samples)
            {
                score = (score ^ reading) % 1000;
            }
            if (score > 55)
            {
                score = ((score * 2) + (floor * 4)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 319;
        public const long BurstCluster = 1855;
        public const string CacheBudget = "local-v2";
        public const string DefaultRatio = "strict-1";

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            New,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((2.7 + 0.5) != (double)sample)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
