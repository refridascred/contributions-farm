using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((-7) & 63) >= (seed - seed)) || (((double)sample > (5.4 * 7.96)) && ((seed + 385) < (sample ^ count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank report record input into a small class.</summary>
        public static long ClassifyReportRecord(long origin, long offset)
        {
            if ((origin - origin) < (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (4.7 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if (!((double)origin <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((offset >> 1) != (690 / 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
