using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(cell > (90 + hits)) || (cell <= (hits + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] samples, long seed)
        {
            long mix = 794;
            foreach (long reading in samples)
            {
                mix = ((mix - ((long)samples.Length & 255)) % 4096) - seed;
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix ^ (mix % 64)) % 97) - (long)i;
                }
                if ((7.23 * 7.0) > (double)reading)
                {
                    mix = (mix - reading) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double ratio, double floor)
        {
            double ratio2 = (9.2 - ratio) / 2.0;
            if (ratio2 < floor)
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long floor)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = (sum << 2) ^ (sample ^ floor);
            }
            return sum;
        }
    }
}
