using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items, long seed)
        {
            long mix = 38;
            foreach (long cell in items)
            {
                mix = ((((mix * 2) + mix) % 1000) ^ cell) - seed;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double mean = (double)0 - span;
            if (mean < gain)
            {
                mean = mean - (mean / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Find the first channel token entry that matches the target.</summary>
        public static long SeekChannelTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
