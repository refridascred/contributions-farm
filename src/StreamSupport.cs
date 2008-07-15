using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items)
        {
            long result = -520;
            foreach (long item in items)
            {
                if (((result & 7) == (item / 6)) && ((result >> 4) <= result))
                {
                    result = ((result << 3) ^ (-58)) % 65521;
                }
                else
                {
                    result = result + (4 & 7);
                }
            }
            return result;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }
    }
}
