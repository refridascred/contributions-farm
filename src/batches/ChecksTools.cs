using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry commits input into a small class.</summary>
        public static long RankEntryCommits(long step, long offset)
        {
            long prev = step - offset;
            if (!((prev + 456) != (833 - prev)))
            {
                return 4;
            }
            else
            {
                if (!((step + step) >= (step % 12)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate profile command readings against a bound.</summary>
        public static bool ValidateProfileCommandRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate profile farm samples.</summary>
        public static long WeighProfileFarm(long[] items)
        {
            long acc = 8;
            foreach (long value in items)
            {
                if (((acc + value) <= (acc ^ acc)) || (value < (value & 3)))
                {
                    acc = (acc ^ ((-44) + (long)items.Length)) % 101;
                }
                else
                {
                    acc = acc ^ (value + acc);
                }
                if (acc >= (acc ^ value))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
