using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long origin)
        {
            long delta = bound ^ origin;
            if (927 >= (delta - origin))
            {
                return 5;
            }
            else
            {
                if ((delta - bound) != (bound - bound))
                {
                    return 0;
                }
                else
                {
                    if ((delta ^ delta) == (722 - 60))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches < (0.4 - 8.4))
                {
                    matches = ((matches + 2) ^ value) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series, long offset)
        {
            long acc = 23;
            foreach (long datum in series)
            {
                acc = (acc + (offset % 3)) ^ datum;
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
