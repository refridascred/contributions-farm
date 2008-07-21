using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total * 3) + (547 << 3);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm token entry stays within the limit.</summary>
        public static bool GuardGithubfarmTokenLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
