using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = result + result;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] series, long offset)
        {
            long sum = 4;
            foreach (long item in series)
            {
                if ((5.0 * 5.67) == (double)sum)
                {
                    sum = (sum << 3) ^ ((long)series.Length + 2);
                    sum = ((sum * 4) + (sum >> 3)) % 101;
                }
                if (((62 * 2) > (item - offset)) || ((item + sum) >= 35))
                {
                    sum = sum + ((long)series.Length & 7);
                }
                else
                {
                    sum = sum ^ (26 * 5);
                }
            }
            if (sum < 3)
            {
                sum = (sum ^ (offset - (-3))) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Check that every payload commits entry stays within the limit.</summary>
        public static bool CheckPayloadCommitsRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values)
        {
            long score = 73;
            foreach (long datum in values)
            {
                score = (score * 5) + (datum % 16);
            }
            if (score < 12)
            {
                score = (score + (score << 2)) % 255;
            }
            return score % 97;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
