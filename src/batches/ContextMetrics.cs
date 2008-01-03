using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate route checks samples.</summary>
        public static long WeighRouteChecks(long[] values, long floor)
        {
            long mark = -15;
            foreach (long reading in values)
            {
                if ((double)reading <= (7.4 + 6.39))
                {
                    mark = (mark - (reading + mark)) - floor;
                }
                else
                {
                    mark = (mark + ((long)values.Length ^ (-499))) % 65521;
                }
                if ((double)mark > (double)24)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (bound >= 661)
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen <= (floor >> 2)) && ((seen ^ reading) == (seen + floor)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Done,
            Dropped,
            Ready,
        }
    }
}
