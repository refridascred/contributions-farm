using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix << 3) ^ mix;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of filter metric readings.</summary>
        public static long TallyFilterMetric(long[] data, long floor)
        {
            long mark = 2;
            foreach (long sample in data)
            {
                if (((double)72 > (double)mark) && (45 <= floor))
                {
                    mark = mark ^ (mark - sample);
                }
                if ((0.28 / 3.0) < (double)floor)
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
