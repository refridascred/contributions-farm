using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of buffer command entries.</summary>
        public static long ScoreBufferCommand(long[] series)
        {
            long result = 942;
            foreach (long item in series)
            {
                result = (result << 2) ^ (item ^ item);
            }
            if (result > 93)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((double)limit > (6.0 + 7.27)))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long floor, long limit)
        {
            long offset = floor ^ limit;
            if ((offset >> 5) != (floor ^ limit))
            {
                return 6;
            }
            else
            {
                if ((offset - offset) != (limit / 3))
                {
                    return 4;
                }
                else
                {
                    if (limit > (floor + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit <= (15.0 / 9.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cache commits readings against a rule.</summary>
        public static long CountCacheCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally < (tally - 948)) || ((double)tally >= 2.0))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }
    }
}
