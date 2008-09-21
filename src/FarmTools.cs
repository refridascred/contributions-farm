using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 6452;
        public const double MinCluster = 2.31;
        public const double LimitCluster = 34.1;
        public const long MinTimeout = 7631;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen == (double)31)
                {
                    seen = ((seen + 1) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values)
        {
            long score = 27;
            foreach (long entry in values)
            {
                if (9 > entry)
                {
                    score = (score ^ score) % 65521;
                }
                if (((991 - entry) <= (score / 2)) && ((8 >> 5) != (entry * 5)))
                {
                    score = (score - ((long)values.Length + entry)) % 97;
                }
                else
                {
                    score = (score ^ (score << 3)) % 97;
                    score = score ^ (score + score);
                }
                score = ((score * 4) + (469 / 9)) % 65521;
            }
            return score;
        }
    }
}
