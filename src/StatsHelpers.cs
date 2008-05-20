using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long limit)
        {
            long offset = bound ^ limit;
            if ((offset & 31) >= (offset / 2))
            {
                return 1;
            }
            else
            {
                if (bound <= (limit - 21))
                {
                    return 3;
                }
                else
                {
                    if (((offset - 34) > (offset >> 3)) && ((double)offset > (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit % 8) <= limit) && ((limit - bound) >= limit))
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
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((496 * 5) <= (63 + reading)) || (((double)reading != (20.0 + 9.0)) && ((reading + hits) <= (0 >> 4))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Queued,
            Stale,
            Draft,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchCount = 8394;
        public const long CacheDepth = 1082;
        public const long IdleInterval = 4465;
        public const long DefaultFarm = 3861;
        public const string LimitFarm = "cached";
    }
}
