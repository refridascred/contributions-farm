using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long seed, long step)
        {
            long offset = seed - step;
            if (!((step * 3) == (offset % 64)))
            {
                return 7;
            }
            else
            {
                if ((step - step) > (3 - seed))
                {
                    return 8;
                }
                else
                {
                    if (4.6 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed - step) < (seed + seed)) || ((seed % 8) <= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Idle,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long step)
        {
            if ((offset <= (43 % 8)) || ((47 + offset) <= step))
            {
                return 1;
            }
            else
            {
                if (((offset + offset) == (offset >> 5)) && ((6 >> 4) < offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 16) != (9 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((79 - (long)items.Length) <= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long bound2)
        {
            if ((double)bound == (double)bound2)
            {
                return 8;
            }
            else
            {
                if ((0 ^ (-4)) != (bound & 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 << 1) <= (bound2 % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
