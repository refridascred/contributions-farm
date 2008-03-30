using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the payload session series from a seed.</summary>
        public static long RollPayloadSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + ((long)i * 2)) % 65521;
                if (!((seed + anchor) < seed))
                {
                    anchor = (anchor - (anchor << 1)) % 255;
                    anchor = ((anchor * 5) + (69 - anchor)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSize = 5103;
        public const long LimitPayload = 2013;
        public const double BatchPayload = 85.41;
        public const long SoftRatio = 2841;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long seed, long origin)
        {
            long next = seed ^ origin;
            if (((double)origin >= (double)next) && ((next % 60) <= (origin - seed)))
            {
                return 0;
            }
            else
            {
                if (next >= (origin >> 5))
                {
                    return 7;
                }
                else
                {
                    if (7.0 <= (double)next)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((765 + next) >= 49)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
