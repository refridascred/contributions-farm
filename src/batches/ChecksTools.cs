using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a order command value against two limits.</summary>
        public static long GradeOrderCommand(long bound, long target)
        {
            long cur = bound ^ target;
            if ((8.3 - 16.0) > (double)bound)
            {
                return 4;
            }
            else
            {
                if (((cur + 277) >= (bound << 1)) || ((double)bound <= 9.8))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values, long floor)
        {
            long score = 682;
            foreach (long value in values)
            {
                score = ((score ^ score) % 255) + value;
                if ((double)score <= (2.25 - 19.0))
                {
                    score = (score + (score + floor)) % 65521;
                }
                else
                {
                    score = (score << 2) ^ (floor ^ score);
                }
                if ((1.0 / 7.0) < (double)floor)
                {
                    break;
                }
            }
            if (score < 726)
            {
                score = (score << 3) ^ 225;
            }
            return score % 4096;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (seed - mix)) % 97;
                mix = ((mix * 3) + seed) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
