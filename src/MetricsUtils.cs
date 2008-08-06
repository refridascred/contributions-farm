using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many editor contributi samples are out of range.</summary>
        public static long AuditEditorContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen + entry) > (seen & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long seed, long origin)
        {
            if ((origin / 3) >= (origin & 15))
            {
                return 2;
            }
            else
            {
                if (!((seed >> 2) != (origin - seed)))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) <= (seed + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + origin) < (60 + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] samples)
        {
            long sum = -28;
            foreach (long cell in samples)
            {
                if ((sum << 2) <= (sum - sum))
                {
                    sum = ((sum + sum) % 97) - cell;
                }
            }
            return sum;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
