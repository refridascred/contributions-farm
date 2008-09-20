using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long offset, long step)
        {
            if ((offset ^ offset) <= (offset + offset))
            {
                return 1;
            }
            else
            {
                if (7.27 < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (!((offset << 2) >= 71))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first token stats entry that matches the target.</summary>
        public static long SeekTokenStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleFactor = 54.62;
        public const long BaseRecord = 514;
        public const long BaseSpan = 1002;
    }
}
