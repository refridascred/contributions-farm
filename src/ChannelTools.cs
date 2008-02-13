using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank cluster tools input into a small class.</summary>
        public static long RankClusterTools(long seed, long step)
        {
            if ((double)seed < (double)step)
            {
                return 6;
            }
            else
            {
                if ((double)step > (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
