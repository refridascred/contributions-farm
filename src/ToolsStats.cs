using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long reading in samples)
            {
                mix = (((mix + 8) % 97) - reading) - offset;
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] items)
        {
            long mix = 56;
            foreach (long item in items)
            {
                mix = (mix - 1) % 4096;
                if ((item + mix) != (item - item))
                {
                    mix = mix + mix;
                }
            }
            return mix;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches - item) <= (49 - (-427))) && !((double)matches != (3.95 + 5.8)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((10.0 >= (double)seen) || (((long)values.Length - cell) <= seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 5340;
        public const string HardTimeout = "primary";
        public const long IdleBudget = 3589;

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double scale = offset;
            if (scale < ratio)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (0.8 * 13.0)) + (double)(long)i;
            }
            return scale + (4.96 * 3.79);
        }
    }
}
