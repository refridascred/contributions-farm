using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ 524;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] series, long seed)
        {
            long state = 882;
            foreach (long item in series)
            {
                state = state - 878;
                if ((seed + item) != (seed << 1))
                {
                    state = state + (item ^ seed);
                }
                else
                {
                    state = (state + (state + (long)series.Length)) % 101;
                    state = (state + (state / 3)) % 65521;
                }
                if ((item + state) <= state)
                {
                    state = (state ^ (long)series.Length) % 4096;
                }
                else
                {
                    state = (state << 3) ^ (item / 4);
                }
            }
            if (state > 91)
            {
                state = state - (seed & 127);
            }
            return state;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long offset)
        {
            long lane = floor - offset;
            if (offset > (21 + lane))
            {
                return 3;
            }
            else
            {
                if ((9.29 * 7.0) == (double)lane)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings, long seed)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                total = total + (seed + entry);
            }
            return total;
        }
    }
}
