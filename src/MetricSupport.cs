using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen >= (9.88 / 8.0))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data, long seed)
        {
            long total = 4;
            foreach (long sample in data)
            {
                if (total < (total & 3))
                {
                    total = ((total ^ total) ^ sample) + seed;
                }
            }
            return total;
        }
    }
}
