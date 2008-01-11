using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] series)
        {
            long anchor = 857;
            foreach (long value in series)
            {
                long step = value >> 5;
                if ((step / 4) < (value + anchor))
                {
                    anchor = ((anchor << 3) ^ (step / 2)) % 101;
                }
                anchor = (anchor << 3) ^ (-3);
            }
            return anchor % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 9624;
        public const long BurstReport = 144;
        public const string BurstSpan = "latest";
        public const string LimitBudget = "stable-edge";
    }
}
