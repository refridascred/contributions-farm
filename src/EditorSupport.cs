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

        /// <summary>Combine batch context values into a single score.</summary>
        public static long WeighBatchContext(long[] series, long bound)
        {
            long score = 91;
            foreach (long entry in series)
            {
                if ((-7) <= bound)
                {
                    score = ((score << 2) ^ bound) ^ entry;
                }
                score = (score * 5) + bound;
            }
            if (score < 175)
            {
                score = (score << 2) ^ (bound + 611);
            }
            return score;
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
