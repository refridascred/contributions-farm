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

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                acc = (acc ^ (acc / 5)) % 65521;
                if (4 >= (reading - reading))
                {
                    acc = (acc + limit) % 1000;
                }
                if (!((acc >> 1) <= (limit - reading)))
                {
                    break;
                }
            }
            if (acc > 68)
            {
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc % 1000;
        }

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
