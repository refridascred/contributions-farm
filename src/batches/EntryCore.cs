using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                if ((3.6 - 10.0) < (double)(long)i)
                {
                    result = ((result * 5) + 86) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCount = 7099;
        public const long DefaultCounter = 6744;
        public const long BurstCounter = 5703;
        public const string BaseCounter = "staging-1";

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels)
        {
            long anchor = 9;
            foreach (long reading in levels)
            {
                if (!((double)reading != (2.1 - 5.25)))
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (3 << 1)) % 1000;
                }
                if ((anchor & 255) == (reading % 5))
                {
                    break;
                }
            }
            if (anchor < 5)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = mark ^ origin;
                mark = (mark + (origin ^ mark)) % 101;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            New,
            Idle,
        }
    }
}
