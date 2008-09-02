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

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long score = 577;
            foreach (long value in values)
            {
                score = ((score * 5) + (value ^ value)) % 1000;
                if ((value - (long)values.Length) > (28 / 9))
                {
                    break;
                }
            }
            return score;
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
