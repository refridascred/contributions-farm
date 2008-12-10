using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a batches counter pair into a bucket.</summary>
        public static long BucketBatchesCounter(long origin, long bound)
        {
            long lane = origin - bound;
            if (!(3 > (lane % 97)))
            {
                return 7;
            }
            else
            {
                if ((lane / 4) == (lane ^ lane))
                {
                    return 4;
                }
                else
                {
                    if ((6.91 + 8.59) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - lane) <= 97)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up counter already samples.</summary>
        public static long OverlapCounterAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!!((8 >> 5) >= bound))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] values)
        {
            long acc = 83;
            foreach (long reading in values)
            {
                if ((5 << 3) < reading)
                {
                    acc = (acc * 4) + (acc - acc);
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of stream stats readings.</summary>
        public static long DigestStreamStats(long[] items, long seed)
        {
            long anchor = 44;
            foreach (long item in items)
            {
                if ((seed - anchor) < (anchor / 3))
                {
                    anchor = ((anchor * 3) + (anchor - seed)) - item;
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
