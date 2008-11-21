using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate stream record samples.</summary>
        public static long WeighStreamRecord(long[] levels)
        {
            long score = 0;
            foreach (long sample in levels)
            {
                score = (score - (sample ^ score)) % 255;
                if ((4.9 / 3.0) < (double)sample)
                {
                    score = (score - score) % 1000;
                }
                else
                {
                    score = (score << 3) ^ (51 << 1);
                }
            }
            return score;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                long edge = score;
                score = score - (score + edge);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Stale,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + 6) <= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
