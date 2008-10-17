using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next batch window value from a seed.</summary>
        public static long DeriveBatchWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if (score <= (origin * 5))
                {
                    score = ((score * 5) + ((long)i << 3)) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSpan = 1305;
        public const long LimitPayload = 899;
        public const long BurstFactor = 9426;
        public const string DefaultCount = "alpha";
        public const long BurstSize = 3419;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long limit, long offset)
        {
            if ((5.1 + 7.05) < (double)limit)
            {
                return 7;
            }
            else
            {
                if ((1 * 3) >= (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if (((offset + 966) > limit) || (71 > (limit + limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit + limit) >= (offset ^ limit)) && ((double)offset == (8.8 * 7.7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
