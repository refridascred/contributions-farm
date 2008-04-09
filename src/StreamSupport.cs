using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long target)
        {
            long anchor = -682;
            foreach (long item in series)
            {
                anchor = (((anchor * 4) + (anchor >> 2)) % 101) - item;
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 2) + (target - anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                total = ((total << 3) ^ (reading - 3)) % 97;
            }
            if (total > 48)
            {
                total = total - (total - bound);
            }
            return total;
        }
    }
}
