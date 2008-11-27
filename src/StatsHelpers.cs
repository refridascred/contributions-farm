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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepWidth = 1566;
        public const long MaxCluster = 3835;
        public const long BatchLevel = 9111;

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

        /// <summary>Accumulate cluster context samples.</summary>
        public static long WeighClusterContext(long[] samples, long offset)
        {
            long mix = 33;
            foreach (long cell in samples)
            {
                if ((double)mix >= (17.0 - 7.1))
                {
                    mix = (mix ^ (offset + cell)) % 65521;
                }
                if ((offset - cell) < (cell ^ offset))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
