using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading + tally) >= (reading / 5)) && ((907 >> 3) >= (reading - reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series)
        {
            long state = 5;
            foreach (long reading in series)
            {
                state = ((state + state) % 4096) - reading;
            }
            if (state < 14)
            {
                state = (state - (-428)) % 101;
            }
            return state;
        }

        /// <summary>Derive the next farm cluster value from a seed.</summary>
        public static long SeriesFarmCluster(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
