using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (((anchor << 3) ^ (step - anchor)) % 1000) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count < (6.0 * 9.0))
                {
                    count = ((count + 3) ^ datum) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Dropped,
            Stale,
            Done,
            New,
        }

        /// <summary>Roll a batches order counter forward.</summary>
        public static long SeriesBatchesOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = (score - target) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if (!((offset ^ offset) < 7))
            {
                return 8;
            }
            else
            {
                if ((3 ^ offset) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor * 3) >= (floor << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
