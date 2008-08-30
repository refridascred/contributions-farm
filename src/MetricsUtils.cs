using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double scale = (double)(675 + 948);
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - (scale - ratio)) + (double)(long)i) - bias;
            }
            return scale - (11.0 - scale);
        }

        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long MeasureFarmStreamGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((9.0 - 4.92) != (double)tally) && ((reading + (-59)) > 486))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile already value.</summary>
        public static double ScaleProfileAlready(double weight, double bias)
        {
            double scale = (double)51 / 3.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale - scale) - (double)(long)i) + weight) + bias;
            }
            return scale + (scale / 7.0);
        }
    }
}
