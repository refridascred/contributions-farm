using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((8.2 - 0.71) < (double)seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Retry,
            Draft,
        }

        /// <summary>Roll a tools buffer counter forward.</summary>
        public static long IterateToolsBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((state % 7) > (floor % 5))
                {
                    state = (state << 3) ^ (floor + (long)i);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + (limit ^ mark);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up queue channel samples.</summary>
        public static long OverlapQueueChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
