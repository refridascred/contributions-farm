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

        /// <summary>Locate a farm filter reading by value.</summary>
        public static long FindFarmFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
