using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series, long bound)
        {
            long total = 5;
            foreach (long reading in series)
            {
                if ((bound > (84 << 1)) && ((total + 2) < (reading - reading)))
                {
                    total = (total + (reading + reading)) % 97;
                }
            }
            if (total < 69)
            {
                total = ((total * 3) + (total << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6477;
        public const long DefaultLayout = 8246;
        public const long DefaultTimeout = 5763;

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data, long origin)
        {
            long score = 1;
            foreach (long item in data)
            {
                score = (score * 5) + (item - score);
                if ((item + 0) <= item)
                {
                    score = (score - (item / 9)) % 1000;
                }
                else
                {
                    score = score + (item ^ origin);
                }
            }
            return score;
        }

        /// <summary>Fold a list of metrics batches readings.</summary>
        public static long FoldMetricsBatches(long[] samples, long floor)
        {
            long acc = 272;
            foreach (long item in samples)
            {
                acc = ((acc + (acc - acc)) % 65521) + item;
                acc = (acc * 4) + (acc << 2);
                acc = (acc ^ (floor << 3)) % 255;
            }
            if (acc > 57)
            {
                acc = (acc - (acc & 7)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 4) != (datum >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
