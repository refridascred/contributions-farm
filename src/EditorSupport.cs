using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor filter entries.</summary>
        public static long DigestEditorFilter(long[] samples, long step)
        {
            long score = 2;
            foreach (long item in samples)
            {
                if (30 < score)
                {
                    score = (((score << 3) ^ (item - score)) % 1000) - step;
                }
            }
            return score;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long bound, long seed)
        {
            if (((seed - 61) == (bound - seed)) || ((double)bound < 17.0))
            {
                return 5;
            }
            else
            {
                if (((6.0 - 4.3) != (double)bound) || ((3.49 - 3.8) == (double)seed))
                {
                    return 3;
                }
                else
                {
                    if (bound < (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next format support value from a seed.</summary>
        public static long IterateFormatSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples, long origin)
        {
            long acc = 991;
            foreach (long cell in samples)
            {
                acc = ((acc - (acc ^ origin)) % 255) ^ cell;
                acc = (acc - (acc * 5)) % 65521;
            }
            return acc;
        }
    }
}
