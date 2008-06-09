using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue token pair into a bucket.</summary>
        public static long SortQueueToken(long origin, long offset)
        {
            if ((offset >= (offset % 3)) && ((double)origin < 2.0))
            {
                return 4;
            }
            else
            {
                if ((origin > (offset - origin)) || ((7 - offset) > 81))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (95 / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long score = 90;
            foreach (long cell in samples)
            {
                if ((cell << 3) != (score + limit))
                {
                    score = ((score * 4) + cell) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many order githubfarm samples are out of range.</summary>
        public static long TallyOrderGithubfarmHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((((long)data.Length << 1) < (step >> 3)) || ((75 ^ (long)data.Length) <= (8 * 4))))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
