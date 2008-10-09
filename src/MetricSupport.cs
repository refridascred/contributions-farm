using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a metrics payload counter forward.</summary>
        public static long RollMetricsPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            long lane = target ^ bound;
            if (((95 + 45) == (target << 3)) && (2.8 >= (double)bound))
            {
                return 8;
            }
            else
            {
                if ((bound <= (lane - bound)) || (target > bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)target != (10.0 / 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
