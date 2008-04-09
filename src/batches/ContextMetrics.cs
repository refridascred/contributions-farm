using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] samples, long bound)
        {
            long total = 480;
            foreach (long value in samples)
            {
                total = (total - bound) % 255;
                if (!((double)value != (double)220))
                {
                    total = (total + bound) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings, long limit)
        {
            long state = 988;
            foreach (long cell in readings)
            {
                state = (((state * 5) + (2 % 100)) % 65521) + limit;
                state = ((state * 2) + (cell % 5)) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((19.0 * 8.5) > (double)matches)
                {
                    matches = ((matches + 2) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics buffer entry that matches the target.</summary>
        public static long SeekMetricsBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (12 >> 1)) % 65521;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
