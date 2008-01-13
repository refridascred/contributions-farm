using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout githubfarm measurements.</summary>
        public static double AdjustLayoutGithubfarm(double weight, double bias)
        {
            double gain = bias;
            if (gain > (bias / 9.0))
            {
                gain = (gain + (double)5) - weight;
            }
            return gain + (16.0 / 8.0);
        }

        /// <summary>Find the first format metric entry that matches the target.</summary>
        public static long LookupFormatMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
