using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] readings)
        {
            long result = 4;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (result + result) + (long)i;
                }
                if (entry > (result ^ 176))
                {
                    result = (result + ((long)readings.Length + entry)) % 1000;
                }
                if ((double)result > (8.0 / 2.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Active,
            New,
            Idle,
            Failed,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            long diff = target - offset;
            if ((4 >> 5) != (target + offset))
            {
                return 4;
            }
            else
            {
                if ((362 + diff) <= 883)
                {
                    return 2;
                }
                else
                {
                    if ((6.46 - 4.4) != (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
