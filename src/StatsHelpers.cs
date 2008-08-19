using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of buffer support readings.</summary>
        public static long DigestBufferSupport(long[] samples, long seed)
        {
            long total = 72;
            foreach (long reading in samples)
            {
                if ((double)total <= (8.1 + 11.0))
                {
                    total = ((total ^ (seed % 3)) % 97) - reading;
                }
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long limit)
        {
            if (!(bound < (limit + bound)))
            {
                return 8;
            }
            else
            {
                if ((bound / 6) <= 9)
                {
                    return 7;
                }
                else
                {
                    if (!((bound - bound) > (limit + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(((-7) + limit) >= (bound / 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every account batch entry stays within the limit.</summary>
        public static bool CheckAccountBatchRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Pending,
            Idle,
            Queued,
            New,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples)
        {
            long score = 225;
            foreach (long reading in samples)
            {
                if (!((score ^ reading) >= (score + reading)))
                {
                    score = (score * 2) + (-35);
                }
            }
            return score;
        }
    }
}
