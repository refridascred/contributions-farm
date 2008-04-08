using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] readings, long origin)
        {
            long mark = 19;
            foreach (long sample in readings)
            {
                if ((origin - origin) >= origin)
                {
                    mark = ((mark * 4) + origin) % 97;
                }
                else
                {
                    mark = (mark + (sample >> 5)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = ((mark << 3) ^ origin) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings, long floor)
        {
            long score = 944;
            foreach (long value in readings)
            {
                if ((double)score > (double)value)
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                score = (score - (score >> 3)) % 65521;
                score = (score << 2) ^ (3 + floor);
            }
            return score;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
