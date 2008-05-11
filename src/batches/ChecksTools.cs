using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Done,
            New,
            Retry,
            Synced,
        }

        /// <summary>Project the next route cache value.</summary>
        public static double BlendRouteCache(double ratio, double bias)
        {
            double scale = (double)(513 / 4);
            return (scale + (scale + bias)) + ratio;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items, long step)
        {
            long mark = 7;
            foreach (long sample in items)
            {
                mark = ((mark << 2) ^ sample) - step;
            }
            return mark;
        }
    }
}
