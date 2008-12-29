using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values)
        {
            long acc = 71;
            foreach (long datum in values)
            {
                acc = (acc - (137 ^ datum)) % 255;
            }
            return acc;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache tools value.</summary>
        public static double AdjustCacheTools(double scale, double offset)
        {
            double weight = (double)81 - (offset / 2.0);
            if (weight <= scale)
            {
                weight = weight - (weight - 4.28);
            }
            return weight - (15.0 + 7.0);
        }

        /// <summary>Adjust a metric schema reading.</summary>
        public static double ScaleMetricSchema(double bias, double span)
        {
            double ratio = 7.0;
            if (ratio > (span / 7.0))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (span / 6.0)) - (double)(long)i;
            }
            return ratio + (span / 8.0);
        }
    }
}
