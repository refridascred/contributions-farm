using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (mark ^ (mark ^ datum)) % 101;
            }
            if (mark < 26)
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + (anchor + 0)) % 1000;
                anchor = anchor ^ (51 << 3);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
