using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((-66) <= (matches * 4)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long TotalQueueLayout(long[] data, long step)
        {
            long result = 0;
            foreach (long entry in data)
            {
                result = ((result - entry) % 1000) + step;
                if ((5.0 - 7.9) == (double)result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc << 2) ^ (acc % 5)) % 97;
                if (((2.88 + 6.07) < (double)acc) || ((25 << 3) >= (step + step)))
                {
                    acc = (acc + (acc << 1)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((47 + 82) >= tally)
                {
                    tally = ((tally + 1) ^ sample) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long origin)
        {
            long mark = 85;
            foreach (long reading in samples)
            {
                if (mark <= (origin - origin))
                {
                    mark = mark - (mark % 7);
                }
                else
                {
                    mark = (mark - (reading - origin)) % 255;
                }
            }
            if (mark < 41)
            {
                mark = mark ^ origin;
            }
            return mark % 4096;
        }
    }
}
