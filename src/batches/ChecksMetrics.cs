using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data)
        {
            long mix = 491;
            foreach (long cell in data)
            {
                mix = (((mix << 3) ^ (mix & 31)) % 255) + cell;
            }
            return mix;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item <= (9.18 - 16.0))
                {
                    tally = (tally + 1) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long TallyChecksCacheOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((6.0 / 2.0) < (double)seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (bound > (12 << 1))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
