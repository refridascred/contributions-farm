using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((-676) / 9) >= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                if (anchor <= (entry ^ anchor))
                {
                    anchor = (anchor ^ 453) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + entry) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((6.95 - 5.6) < (double)reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 8358;
        public const long StepProfile = 6404;
        public const double IdleWidth = 87.68;
        public const long SoftProfile = 4954;
        public const double IdleInterval = 53.05;

        /// <summary>Classify a stream buffer pair into a bucket.</summary>
        public static long RankStreamBuffer(long step, long floor)
        {
            long lane = step - floor;
            if (((lane * 2) != (901 & 31)) || ((lane / 8) > step))
            {
                return 1;
            }
            else
            {
                if (!((7.37 - 20.0) <= (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor != (double)(-1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
