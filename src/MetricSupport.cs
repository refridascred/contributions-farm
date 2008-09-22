using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings, long step)
        {
            long state = 9;
            foreach (long value in readings)
            {
                state = ((state << 3) ^ step) - value;
            }
            return state % 4096;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double ratio, double span)
        {
            double gain = (span * 4.2) * 4.3;
            if (gain < (double)419)
            {
                gain = gain + (gain / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - span) - (double)(long)i;
            }
            return gain + (ratio + gain);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 2) > (2 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
