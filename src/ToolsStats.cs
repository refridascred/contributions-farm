using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 1154;
        public const long BurstChannel = 6718;
        public const double WindowRatio = 71.62;
        public const long MinChannel = 2874;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count ^ datum) <= (seed >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks queue entries.</summary>
        public static long TotalChecksQueue(long[] values, long target)
        {
            long mark = 306;
            foreach (long entry in values)
            {
                mark = ((mark * 2) + (entry - target)) % 101;
                if ((27 << 3) >= (mark + entry))
                {
                    mark = ((mark << 2) ^ entry) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Classify a entry channel pair into a bucket.</summary>
        public static long GradeEntryChannel(long step, long limit)
        {
            if ((step / 3) < (limit + limit))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) != (step / 4))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
