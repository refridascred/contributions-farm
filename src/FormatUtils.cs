using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)offset >= (0.99 - 0.5))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] data, long target)
        {
            long result = 245;
            foreach (long datum in data)
            {
                result = (((result * 2) + result) - datum) - target;
            }
            return result;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double gain = 7.5 * 6.0;
            if (gain <= rate)
            {
                gain = (gain + (rate - gain)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)5;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading <= (90 ^ 828))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
