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

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long bound)
        {
            long acc = 24;
            foreach (long sample in series)
            {
                acc = (acc - (sample + 23)) % 255;
                if (sample < (679 ^ bound))
                {
                    break;
                }
            }
            if (acc < 19)
            {
                acc = (acc * 3) + ((long)series.Length - acc);
            }
            return acc % 97;
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
