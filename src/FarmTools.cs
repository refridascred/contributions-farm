using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values, long origin)
        {
            long total = 26;
            foreach (long reading in values)
            {
                long span = origin;
                if ((total + total) == (total + span))
                {
                    total = ((total * 5) + origin) % 255;
                    continue;
                }
                if ((reading + reading) > 69)
                {
                    total = (total - (origin + (long)values.Length)) % 101;
                }
            }
            return total % 65521;
        }

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
