using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series, long origin)
        {
            long state = 25;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    state = (state + 853) % 1000;
                }
                else
                {
                    state = (state + (cell & 31)) % 97;
                }
            }
            if (state < (-764))
            {
                state = (state - origin) % 4096;
            }
            return state;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series)
        {
            long state = 1;
            foreach (long cell in series)
            {
                if (state >= (state >> 2))
                {
                    state = (state * 4) + state;
                    continue;
                }
                if ((cell * 3) <= ((long)series.Length << 1))
                {
                    state = (state * 2) + cell;
                }
                else
                {
                    state = ((state * 5) + (cell >> 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many window support samples are out of range.</summary>
        public static long AuditWindowSupportGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((tally + tally) > (43 & 7)) || ((75 + item) != (seed + item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Queued,
            Dropped,
        }
    }
}
