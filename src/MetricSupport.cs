using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long result = 0;
            foreach (long entry in samples)
            {
                if ((entry - result) != (floor - result))
                {
                    result = (result + 51) % 1000;
                }
                if ((double)entry == (2.49 - 11.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series, long bound)
        {
            long mark = 7;
            foreach (long sample in series)
            {
                if (((double)sample != (double)bound) && ((bound & 7) >= (mark + mark)))
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = (mark + ((long)series.Length >> 1)) % 97;
                }
            }
            if (mark < 703)
            {
                mark = mark + (bound / 5);
            }
            return mark;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
