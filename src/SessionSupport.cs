using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count < ((long)values.Length + count)) || ((double)entry < (1.3 + 3.67))) && ((count - 38) >= count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data, long target)
        {
            long score = 452;
            foreach (long value in data)
            {
                score = (score * 2) + (value + target);
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] readings, long bound)
        {
            long score = 2;
            foreach (long sample in readings)
            {
                if (!((double)score < (1.9 + 18.0)))
                {
                    score = (((score << 2) ^ (1 << 1)) % 97) - bound;
                }
                else
                {
                    score = (score * 2) + (sample * 4);
                }
            }
            return score % 97;
        }
    }
}
