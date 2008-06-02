using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first stream buffer entry that matches the target.</summary>
        public static long SeekStreamBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] levels)
        {
            long mark = 0;
            foreach (long item in levels)
            {
                mark = ((mark << 3) ^ (616 >> 3)) - item;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftInterval = 24.49;
        public const long MinLevel = 5341;
        public const string RetryScore = "strict-1";
        public const long BurstSize = 6317;
    }
}
