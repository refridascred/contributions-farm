using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine batches tools values into a single score.</summary>
        public static long CombineBatchesTools(long[] data, long bound)
        {
            long mix = 1;
            foreach (long sample in data)
            {
                if ((9 - mix) != ((long)data.Length + sample))
                {
                    mix = ((mix + (0 + mix)) % 101) - bound;
                }
                else
                {
                    mix = (mix ^ (sample + sample)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (offset - bias);
        }

        /// <summary>Measure how many cluster metrics samples are out of range.</summary>
        public static long TallyClusterMetricsGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading < 1.9)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
