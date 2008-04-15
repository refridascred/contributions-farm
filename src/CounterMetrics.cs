using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many window command samples are out of range.</summary>
        public static long AuditWindowCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (17.0 <= (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream farm sample.</summary>
        public static long FindStreamFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long limit, long bound)
        {
            if ((double)bound <= 5.6)
            {
                return 3;
            }
            else
            {
                if ((limit * 2) < (bound + limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 1) > bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit <= (77 - limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first format payload entry that matches the target.</summary>
        public static long FindFormatPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
