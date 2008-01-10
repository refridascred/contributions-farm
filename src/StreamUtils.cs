using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] items)
        {
            long score = 7;
            foreach (long sample in items)
            {
                if ((score - sample) == (long)items.Length)
                {
                    score = ((score * 2) + (score ^ 71)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits & 7) < (cell ^ offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long limit, long offset)
        {
            if (!(137 <= (limit >> 5)))
            {
                return 3;
            }
            else
            {
                if ((3.0 - 14.0) == (double)offset)
                {
                    return 5;
                }
                else
                {
                    if (!((offset & 7) <= (limit >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= 12)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 3447;
        public const double MinScore = 31.14;
        public const long MaxQueue = 1592;
        public const long CacheQueue = 7043;
        public const double DefaultWidth = 67.02;
    }
}
