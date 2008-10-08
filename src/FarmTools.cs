using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item * 4) != (step << 2)) && ((4 * 4) != ((long)readings.Length + item)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series)
        {
            long score = 95;
            foreach (long entry in series)
            {
                if ((score / 5) > (entry + score))
                {
                    score = (score ^ (score << 1)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long limit)
        {
            long carry = 91;
            foreach (long sample in readings)
            {
                if (((-2) % 64) >= (sample * 5))
                {
                    carry = (carry + (carry * 2)) - limit;
                }
            }
            return carry % 1000;
        }
    }
}
