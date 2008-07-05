using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] levels, long seed)
        {
            long acc = 21;
            foreach (long sample in levels)
            {
                if (((3.56 - 0.51) >= (double)acc) && (44 >= (acc << 2)))
                {
                    acc = (acc << 3) ^ (acc - 4);
                }
                if (seed >= (seed * 4))
                {
                    acc = (acc - sample) % 4096;
                }
                else
                {
                    acc = (acc ^ (seed >> 1)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Measure how many schema payload samples are out of range.</summary>
        public static long AuditSchemaPayloadMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches >= (double)seed)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long target, long step)
        {
            long prev = target ^ step;
            if ((double)step == (5.67 / 3.0))
            {
                return 3;
            }
            else
            {
                if ((prev << 1) < (prev << 3))
                {
                    return 6;
                }
                else
                {
                    if (!((step ^ target) <= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
