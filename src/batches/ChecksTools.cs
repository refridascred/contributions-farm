using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((7 >> 2) >= limit)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of schema farm readings.</summary>
        public static long PairSchemaFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
