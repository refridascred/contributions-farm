using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a report format pair into a bucket.</summary>
        public static long RankReportFormat(long origin, long bound)
        {
            long edge = origin ^ bound;
            if (!((bound << 3) >= (66 & 3)))
            {
                return 3;
            }
            else
            {
                if (!(origin >= (origin - edge)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score ^ (long)i) + (long)i2;
                    score = ((score << 2) ^ (offset & 1)) % 255;
                }
                score = (score ^ (offset - offset)) % 255;
                score = (score << 3) ^ (score >> 5);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample < (count >> 1))
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
