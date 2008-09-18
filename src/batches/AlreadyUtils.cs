using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cache metrics samples.</summary>
        public static long ScoreCacheMetrics(long[] samples)
        {
            long state = 18;
            foreach (long entry in samples)
            {
                if ((entry + entry) > state)
                {
                    state = (state << 3) ^ (entry % 2);
                }
                else
                {
                    state = ((state * 5) + (65 & 15)) % 65521;
                }
                if (entry > 87)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit checks command readings against a rule.</summary>
        public static long AuditChecksCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (7.25 * 5.1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
