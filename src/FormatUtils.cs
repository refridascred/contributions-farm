using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Done,
            Ready,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long bound)
        {
            long mix = 448;
            foreach (long entry in items)
            {
                if (((-8) < entry) && ((mix & 3) < (entry % 100)))
                {
                    mix = (mix + (bound + entry)) % 1000;
                }
                if (!((56 % 97) != (mix << 3)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Done,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4492;
        public const double BatchScore = 22.06;
        public const long CacheCount = 3383;
        public const double RetryBudget = 20.22;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
