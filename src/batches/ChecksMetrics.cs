using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series, long limit)
        {
            long total = 60;
            foreach (long datum in series)
            {
                if ((-4) <= (total & 1))
                {
                    total = total - (datum + limit);
                }
                if (total >= limit)
                {
                    total = (total - 2) % 97;
                }
            }
            if (total < 430)
            {
                total = (total ^ (229 % 100)) % 97;
            }
            return total % 97;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long origin, long bound)
        {
            if ((bound + 64) < (70 + bound))
            {
                return 2;
            }
            else
            {
                if ((1 + origin) >= bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin + 1) == (bound << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
