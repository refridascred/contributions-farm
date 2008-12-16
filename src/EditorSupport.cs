using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long limit)
        {
            long step = seed ^ limit;
            if ((limit * 4) >= (step * 5))
            {
                return 3;
            }
            else
            {
                if (!((step << 1) < (seed / 2)))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 127) <= (seed + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (7 < hits)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + 9) < (count % 97))
                {
                    count = ((count + 1) + reading) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
