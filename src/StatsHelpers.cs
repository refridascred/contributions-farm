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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data, long limit)
        {
            long total = -1;
            foreach (long datum in data)
            {
                if ((((long)data.Length + datum) != (total ^ (-9))) && ((datum - limit) == (total & 7)))
                {
                    total = (total ^ (total / 7)) % 4096;
                }
                total = (total + (datum & 255)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheLevel = 1820;
        public const string MinFactor = "legacy-v2";
        public const long BaseScore = 9297;
    }
}
