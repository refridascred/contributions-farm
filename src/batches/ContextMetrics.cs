using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum + offset) % 97) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data, long target)
        {
            long state = 0;
            foreach (long sample in data)
            {
                if (((-2) ^ target) != (target / 7))
                {
                    state = (((state << 3) ^ 9) % 4096) - sample;
                }
            }
            if (state > 2)
            {
                state = ((state << 3) ^ (state & 127)) % 97;
            }
            return state % 97;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < (matches + matches))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
