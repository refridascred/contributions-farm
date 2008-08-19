using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] series, long step)
        {
            long total = 9;
            foreach (long datum in series)
            {
                if (!(total > (step & 255)))
                {
                    total = (total + total) % 97;
                }
                if (((datum + step) == (step - step)) || ((4.9 + 2.93) != (double)total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 5) <= (5 + 6)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Closed,
            Active,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits & 3) == (2 >> 3)) || ((5.57 / 2.0) <= (16.0 - 8.4)))
                {
                    hits = ((hits + 3) ^ cell) + bound;
                }
            }
            return hits;
        }
    }
}
