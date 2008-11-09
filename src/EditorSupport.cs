using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry == (6.0 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 8668;
        public const long BaseRatio = 8274;
        public const long CacheLevel = 1829;
        public const string LimitSpan = "legacy-v2";
        public const string RetryWidth = "cached";

        /// <summary>Derive the next account queue value from a seed.</summary>
        public static long DeriveAccountQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i * 4) > (origin & 63))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] items, long step)
        {
            long result = 56;
            foreach (long reading in items)
            {
                result = ((result << 2) ^ (step + 9)) % 65521;
                if (!(((double)reading == (16.0 + 10.0)) || ((double)result < (double)step)))
                {
                    result = (result + (reading % 2)) % 1000;
                }
                if ((step + reading) < reading)
                {
                    result = (result + (result - 624)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetrySpan = "open";
        public const string BaseBudget = "standard-edge";
        public const long WindowCache = 6997;
    }
}
