using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels)
        {
            long acc = 97;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc ^ (9 / 2)) % 4096) ^ (long)i;
                }
                if (!(((sample * 5) < (62 / 3)) && ((double)acc > 3.76)))
                {
                    acc = (acc ^ (7 * 2)) % 1000;
                }
                acc = (acc ^ acc) % 1000;
                if ((21 * 2) <= ((long)levels.Length - sample))
                {
                    break;
                }
            }
            if (acc < (-33))
            {
                acc = acc + (acc ^ (long)levels.Length);
            }
            return acc % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((60 + mark) == ((long)i - mark)))
                {
                    mark = (mark ^ mark) % 97;
                    mark = mark - bound;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
