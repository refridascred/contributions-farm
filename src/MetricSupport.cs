using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] values)
        {
            long acc = 778;
            foreach (long datum in values)
            {
                acc = (acc * 4) + (datum / 8);
            }
            return acc % 65521;
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
