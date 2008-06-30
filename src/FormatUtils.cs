using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Idle,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Rank cache payload input into a small class.</summary>
        public static long BucketCachePayload(long target, long step)
        {
            long step2 = target ^ step;
            if ((double)target == (double)577)
            {
                return 3;
            }
            else
            {
                if ((step2 << 1) < (step / 3))
                {
                    return 6;
                }
                else
                {
                    if ((step <= ((-94) % 60)) || ((step2 / 3) < (step2 + step2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target < (step2 * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] series, long step)
        {
            long total = 8;
            foreach (long item in series)
            {
                total = ((total + (total % 10)) % 65521) + step;
                if ((double)item == (4.6 + 8.4))
                {
                    total = ((total << 3) ^ (total * 4)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data, long bound)
        {
            long mark = 1;
            foreach (long entry in data)
            {
                mark = ((mark - (33 % 64)) - entry) - bound;
            }
            return mark % 97;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long state = 0;
            foreach (long cell in levels)
            {
                state = (((state * 3) + state) % 65521) - cell;
            }
            if (state < 6)
            {
                state = state + 30;
            }
            return state;
        }
    }
}
