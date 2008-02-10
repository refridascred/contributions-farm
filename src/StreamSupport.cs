using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i & 3) >= offset)
                {
                    score = (score - offset) % 4096;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long floor)
        {
            long acc = 57;
            foreach (long value in items)
            {
                if ((value * 2) >= (acc - acc))
                {
                    acc = acc + value;
                }
                if (((acc - value) >= (floor % 3)) || ((floor << 3) > floor))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
