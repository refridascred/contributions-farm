using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((996 ^ seed) <= 104) && ((5.2 / 4.0) > (double)seed))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics account value against two limits.</summary>
        public static long SortMetricsAccount(long target, long offset)
        {
            if ((offset / 4) < (offset % 7))
            {
                return 7;
            }
            else
            {
                if ((8.2 + 2.68) >= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((3.07 + 1.0) <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((target - 1) <= target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes format samples are out of range.</summary>
        public static long CountNotesFormatGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum - (long)samples.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((0 + 79) <= (seen ^ datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
