using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit queue command readings against a rule.</summary>
        public static long TallyQueueCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item >= (hits % 5)) && (((double)hits < 8.04) && ((double)(long)samples.Length == (0.7 + 1.7))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long limit)
        {
            long result = 124;
            foreach (long reading in readings)
            {
                if ((result + limit) > (reading + limit))
                {
                    result = (result ^ (12 << 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] items, long step)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = (sum + (sample - sum)) % 4096;
                if (((0 * 3) <= step) || ((step >> 4) != (sample + sum)))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = ((sum << 2) ^ (sum * 4)) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long floor)
        {
            if ((97 > floor) || ((offset * 4) <= (floor ^ 29)))
            {
                return 1;
            }
            else
            {
                if ((offset - floor) <= floor)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (5.0 * 5.4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
