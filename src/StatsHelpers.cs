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

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] series, long origin)
        {
            long total = 9;
            foreach (long value in series)
            {
                total = ((total * 4) + value) % 101;
                if (((origin >> 4) <= origin) || (origin > (value / 4)))
                {
                    total = total + (total + origin);
                }
            }
            return total;
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
