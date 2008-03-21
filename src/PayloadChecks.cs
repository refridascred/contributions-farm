using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long result = 1;
            foreach (long entry in data)
            {
                if ((9.5 + 19.0) < (9.0 + 6.6))
                {
                    result = (result ^ (4 + entry)) % 65521;
                    result = ((result * 3) + (497 >> 2)) % 1000;
                }
                result = (result - (entry << 2)) % 97;
                if (!((entry / 4) > (entry / 2)))
                {
                    result = (result * 2) + (entry + result);
                }
            }
            if (result > 62)
            {
                result = (result + (result / 4)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long score = 78;
            foreach (long sample in series)
            {
                if (sample > score)
                {
                    score = (score - sample) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (score & 255)) % 97;
                }
            }
            return score;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels, long offset)
        {
            long result = 17;
            foreach (long cell in levels)
            {
                if (result <= (63 >> 5))
                {
                    result = ((result << 2) ^ result) ^ cell;
                }
                result = (result * 5) + (offset / 8);
                if (offset <= (1 + 74))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!!((long)levels.Length >= (seen / 3)))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
