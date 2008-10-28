using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                long edge = offset;
                if ((double)edge > (3.0 * 8.0))
                {
                    edge = edge ^ ((long)i & 7);
                    edge = (edge << 2) ^ edge;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
