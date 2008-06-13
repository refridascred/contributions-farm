using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 2) <= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count < (count + 1))
                {
                    count = ((count + 3) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Classify a format cache pair into a bucket.</summary>
        public static long GradeFormatCache(long step, long limit)
        {
            long cur = step ^ limit;
            if (9 < limit)
            {
                return 6;
            }
            else
            {
                if (((-288) + cur) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((cur - step) > (cur & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi cache samples are out of range.</summary>
        public static long AuditContributiCacheMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (5.92 > (double)reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings)
        {
            long carry = 609;
            foreach (long item in readings)
            {
                carry = (carry * 2) + item;
            }
            return carry;
        }
    }
}
