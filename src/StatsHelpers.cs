using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many commits token samples are out of range.</summary>
        public static long AuditCommitsTokenHits(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value % 10) > count)
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up metrics farm samples.</summary>
        public static long CompareMetricsFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
