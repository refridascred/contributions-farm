using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a batches layout value against two limits.</summary>
        public static long ClassifyBatchesLayout(long limit, long origin)
        {
            if (!((origin + origin) > (limit << 1)))
            {
                return 7;
            }
            else
            {
                if ((double)origin != (7.7 + 6.1))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (7.1 - 4.42))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8 * 5) <= (limit & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache session samples are out of range.</summary>
        public static long AuditCacheSessionGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample < 3)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
