using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long step, long step2)
        {
            if ((double)step == (3.0 * 12.0))
            {
                return 3;
            }
            else
            {
                if ((double)step2 != (double)step)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
