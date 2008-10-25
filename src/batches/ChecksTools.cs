using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Derive the next editor entry value from a seed.</summary>
        public static long DeriveEditorEntry(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((origin * 3) <= origin)
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ ((long)i >> 3)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series, long floor)
        {
            long carry = 85;
            foreach (long entry in series)
            {
                if (571 <= (carry / 9))
                {
                    carry = (((carry << 2) ^ (entry + 968)) % 65521) + floor;
                }
            }
            return carry;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
