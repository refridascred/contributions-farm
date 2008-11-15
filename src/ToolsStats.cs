using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((5.61 / 9.0) >= (double)tally))
                {
                    tally = ((tally + 3) + value) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Paused,
            Done,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell - cell) >= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if ((offset2 - limit) < (offset2 & 15))
            {
                return 7;
            }
            else
            {
                if (((offset2 >> 4) <= (offset + offset)) || ((offset2 - offset2) != (offset << 3)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 2) ^ (5 + (long)i)) % 65521;
                result = ((result * 3) + ((long)i + 839)) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
