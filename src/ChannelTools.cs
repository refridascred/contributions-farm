using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((limit << 1) < (count + count))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats cluster readings.</summary>
        public static long WeighStatsCluster(long[] items)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                if (!(((long)items.Length >> 2) >= (anchor % 10)))
                {
                    anchor = anchor ^ (57 + anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (value - anchor);
                }
                anchor = (anchor ^ anchor) % 1000;
                anchor = ((anchor * 2) + value) % 255;
                if ((0.32 * 9.6) != (double)anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = acc - (acc - 6);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
