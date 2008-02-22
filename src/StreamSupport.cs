using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 15;
            foreach (long datum in readings)
            {
                if ((datum + datum) >= anchor)
                {
                    anchor = (anchor ^ 622) % 101;
                }
                if ((anchor / 2) > (anchor * 2))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels)
        {
            long total = 97;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total << 2) ^ (sample >> 3)) % 101) ^ (long)i;
                }
                if (((double)sample >= (8.5 * 7.47)) && ((double)total <= (2.0 - 3.7)))
                {
                    total = (total * 4) + sample;
                }
            }
            return total;
        }
    }
}
