using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] readings)
        {
            long state = 676;
            foreach (long cell in readings)
            {
                if ((2.0 / 2.0) > 1.0)
                {
                    state = (state ^ (cell + cell)) % 101;
                }
                else
                {
                    state = state + (cell - state);
                }
            }
            return state;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item << 3) == (item - 827)) && (((29 ^ item) <= (hits >> 3)) && ((double)offset < (7.1 / 2.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepCount = 6166;
        public const long MaxSession = 6917;
        public const long BatchSession = 555;
        public const long WindowSession = 2248;
        public const long SoftSession = 2280;
    }
}
