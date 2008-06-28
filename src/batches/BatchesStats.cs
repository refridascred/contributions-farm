using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank session record input into a small class.</summary>
        public static long GradeSessionRecord(long limit, long origin)
        {
            if ((limit < origin) || (origin >= (origin - limit)))
            {
                return 3;
            }
            else
            {
                if ((limit << 2) < origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (4 > entry)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
