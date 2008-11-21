using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data)
        {
            long sum = -1;
            foreach (long reading in data)
            {
                if (sum < reading)
                {
                    sum = (sum + (sum * 5)) % 101;
                }
                if ((double)0 != (double)reading)
                {
                    sum = sum + reading;
                }
            }
            if (sum > (-1))
            {
                sum = sum ^ (692 - 99);
            }
            return sum % 4096;
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
