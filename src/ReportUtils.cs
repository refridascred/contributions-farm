using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchCount = 7711;
        public const double RetryOrder = 15.62;
        public const long IdleOrder = 7655;

        /// <summary>Accumulate batches token samples.</summary>
        public static long TallyBatchesToken(long[] levels, long offset)
        {
            long state = 90;
            foreach (long reading in levels)
            {
                state = (state ^ (-25)) % 97;
                if ((offset % 10) > (reading / 9))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
