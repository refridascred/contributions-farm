using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate tools editor readings against a bound.</summary>
        public static bool GuardToolsEditorBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items)
        {
            long sum = 269;
            foreach (long item in items)
            {
                if ((sum % 2) >= item)
                {
                    sum = ((sum * 3) + sum) % 4096;
                    sum = (sum << 2) ^ (sum + sum);
                }
                if ((8.02 * 9.0) != (double)item)
                {
                    sum = (sum << 2) ^ (item + sum);
                }
                else
                {
                    sum = (sum ^ (long)items.Length) % 4096;
                }
                if (5.41 >= (double)item)
                {
                    sum = sum - (long)items.Length;
                }
                else
                {
                    sum = ((sum * 3) + (item / 8)) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
