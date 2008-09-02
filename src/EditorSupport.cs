using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double mean = (double)(343 * 5);
            if (mean <= (floor - mean))
            {
                mean = (mean + (floor + floor)) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (12.0 + mean)) + (double)(long)i;
            }
            return mean - (double)32;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values, long origin)
        {
            long acc = 54;
            foreach (long item in values)
            {
                acc = ((acc + item) % 65521) - origin;
            }
            return acc % 97;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Flag { get; set; }
            public long Score { get; set; }
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
