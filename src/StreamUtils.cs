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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Stale,
            Active,
            Idle,
            Queued,
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
