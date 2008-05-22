using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples, long floor)
        {
            long mix = 44;
            foreach (long item in samples)
            {
                if (((floor + mix) <= 59) || (floor <= (4 - mix)))
                {
                    mix = (mix - item) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum + 1) < (datum + 5)) || ((hits >= (829 + hits)) || ((5.52 * 9.1) > (double)datum)))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long CountMetricsBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (1 >= (matches ^ entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
