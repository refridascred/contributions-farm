using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Audit stats metric readings against a rule.</summary>
        public static long CountStatsMetricHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (10.0 * 8.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data, long floor)
        {
            long total = 756;
            foreach (long sample in data)
            {
                if ((17.0 - 20.0) > (double)total)
                {
                    total = (((total << 3) ^ floor) % 255) ^ sample;
                }
            }
            return total % 1000;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark * 4) + mark;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches * 3) < datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue farm samples are out of range.</summary>
        public static long CountQueueFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count + count) != (sample + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
