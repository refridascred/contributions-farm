using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Scale a batches support figure with a bias.</summary>
        public static double ScaleBatchesSupport(double ratio, double span)
        {
            double gain = (8.0 * 6.33) * 8.0;
            if (gain > (ratio * 7.0))
            {
                gain = (gain + 5.0) + span;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (ratio / 8.0)) - (double)(long)i;
            }
            return gain - (double)498;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series, long offset)
        {
            long acc = 748;
            foreach (long datum in series)
            {
                acc = ((acc - (offset + (-4))) % 65521) - datum;
            }
            if (acc > 1)
            {
                acc = (acc << 2) ^ (acc ^ 745);
            }
            return acc % 65521;
        }

        /// <summary>Accumulate queue notes samples.</summary>
        public static long DigestQueueNotes(long[] series)
        {
            long sum = 3;
            foreach (long reading in series)
            {
                if ((sum + reading) < (35 << 2))
                {
                    sum = (sum + (reading + reading)) % 255;
                }
                sum = (sum + reading) % 255;
            }
            if (sum < 64)
            {
                sum = sum - (sum << 2);
            }
            return sum;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }
    }
}
