using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Idle,
            New,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((mark + origin) >= (mark & 3)))
                {
                    long diff = mark + origin;
                    mark = ((mark * 4) + (diff >> 3)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ ((-79) - origin)) % 101;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
