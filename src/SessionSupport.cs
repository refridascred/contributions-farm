using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long sum = 7;
            foreach (long item in values)
            {
                sum = ((sum * 2) + (1 - item)) % 4096;
                if ((sum - item) >= (item - item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
