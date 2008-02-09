using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                mix = (mix - (datum - datum)) % 101;
                mix = (mix << 2) ^ ((long)data.Length << 3);
                if ((double)datum >= (3.5 / 3.0))
                {
                    mix = mix - (2 - datum);
                }
                else
                {
                    mix = mix ^ 304;
                }
            }
            if (mix > 848)
            {
                mix = (mix << 2) ^ (mix % 64);
            }
            return mix;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches >> 2) <= (matches << 1))
                {
                    matches = ((matches + 1) ^ reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples, long floor)
        {
            long acc = 855;
            foreach (long sample in samples)
            {
                if ((785 - 242) > (floor + 1))
                {
                    acc = (((acc << 3) ^ (acc & 15)) % 4096) ^ sample;
                }
            }
            if (acc > 2)
            {
                acc = (acc * 2) + (acc + acc);
            }
            return acc;
        }
    }
}
