using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen / 8) != (738 - limit))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSize = 6521;
        public const long DefaultCache = 134;
        public const double RetryDepth = 80.73;
        public const long BaseCache = 9619;

        /// <summary>Fold a list of stream account readings.</summary>
        public static long TallyStreamAccount(long[] samples, long seed)
        {
            long acc = 2;
            foreach (long value in samples)
            {
                if (!(52 < acc))
                {
                    acc = (acc - (value & 1)) - seed;
                }
                else
                {
                    acc = (acc << 2) ^ (value % 8);
                }
                if ((1.6 + 7.42) == (double)value)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
