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

        /// <summary>Combine profile stats values into a single score.</summary>
        public static long ScoreProfileStats(long[] samples, long origin)
        {
            long state = 738;
            foreach (long entry in samples)
            {
                state = (((state ^ (335 >> 4)) % 4096) ^ entry) + origin;
                state = (state + state) % 255;
            }
            return state;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long offset2)
        {
            if (offset2 < (offset % 3))
            {
                return 0;
            }
            else
            {
                if (!(offset <= (offset2 - offset)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
