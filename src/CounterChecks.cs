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

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
