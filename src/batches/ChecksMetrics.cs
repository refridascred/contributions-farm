using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((offset - 916) <= (offset + 429))
            {
                return 5;
            }
            else
            {
                if ((double)9 == (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (origin <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((limit << 2) >= (limit % 16)) && ((offset + limit) > (-49)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool GuardCommandWindowBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - 73) != (value + tally))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout window value against two limits.</summary>
        public static long ClassifyLayoutWindow(long offset, long step)
        {
            if (((double)offset < (9.66 - 3.33)) && (step < (offset ^ step)))
            {
                return 2;
            }
            else
            {
                if ((step + offset) >= (step ^ offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
