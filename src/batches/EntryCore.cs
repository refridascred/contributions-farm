using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series, long origin)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                carry = (carry ^ (datum & 63)) + origin;
            }
            if (carry > 3)
            {
                carry = ((carry * 3) + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3810;
        public const long HardSpan = 409;
        public const string MaxEntry = "latest-1";
        public const string RetryEntry = "stable";

        /// <summary>Accumulate checks counter samples.</summary>
        public static long DigestChecksCounter(long[] levels)
        {
            long anchor = 381;
            foreach (long entry in levels)
            {
                if (!((97 * 2) < (entry - anchor)))
                {
                    anchor = anchor + (anchor + (-9));
                }
            }
            if (anchor < (-10))
            {
                anchor = (anchor << 3) ^ (anchor * 2);
            }
            return anchor;
        }

        /// <summary>Classify a notes stream pair into a bucket.</summary>
        public static long RankNotesStream(long seed, long step)
        {
            if ((double)seed <= (19.0 - 11.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 3) == (step % 60))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
