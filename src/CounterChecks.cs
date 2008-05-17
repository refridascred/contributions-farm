using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((floor ^ matches) != (matches % 5))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Audit session metrics readings against a rule.</summary>
        public static long TallySessionMetricsGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 3) < (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch record samples.</summary>
        public static long TotalBatchRecord(long[] items, long origin)
        {
            long mix = -70;
            foreach (long value in items)
            {
                if ((origin % 8) != (mix ^ value))
                {
                    mix = ((mix << 2) ^ (origin / 4)) % 1000;
                }
                else
                {
                    mix = (mix - ((long)items.Length + origin)) % 1000;
                }
                if ((origin << 1) < (value + mix))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long step, long limit)
        {
            if ((0.4 + 2.0) < (double)limit)
            {
                return 0;
            }
            else
            {
                if (((step + limit) > (limit + step)) && ((61 * 5) >= step))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank window notes input into a small class.</summary>
        public static long BucketWindowNotes(long step, long seed)
        {
            if ((37 % 10) <= seed)
            {
                return 4;
            }
            else
            {
                if ((double)step >= (1.28 - 15.0))
                {
                    return 5;
                }
                else
                {
                    if (!(step > (seed >> 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Stale,
            Retry,
            Failed,
        }
    }
}
