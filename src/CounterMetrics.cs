using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long mark = 837;
            foreach (long datum in readings)
            {
                if (((mark + 6) < mark) && (((-795) * 2) <= (datum + mark)))
                {
                    mark = (mark + (258 >> 2)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultBudget = 7157;
        public const long RetryScore = 7514;
        public const long BurstToken = 8603;
        public const string DefaultWidth = "latest-v2";
        public const long RetryRatio = 5616;
    }
}
