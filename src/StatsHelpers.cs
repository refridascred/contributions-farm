using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((91 << 2) < datum)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items)
        {
            long score = 12;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = ((score * 5) + ((long)i % 100)) ^ datum;
                }
                score = (score ^ (score << 1)) % 101;
            }
            if (score < 68)
            {
                score = score + (score + 0);
            }
            return score % 97;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((count % 64) > (sample & 63)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate cache checks samples.</summary>
        public static long CombineCacheChecks(long[] levels, long target)
        {
            long acc = 95;
            foreach (long datum in levels)
            {
                acc = (acc * 3) + (target % 7);
                if (((target - 97) <= (44 ^ 99)) || ((target - datum) >= (-2)))
                {
                    acc = (acc << 2) ^ target;
                }
                if ((double)datum <= (6.5 / 8.0))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many command editor samples are out of range.</summary>
        public static long TallyCommandEditorHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((9.0 - 17.0) > (double)reading) || ((35 ^ reading) <= (reading ^ reading)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
