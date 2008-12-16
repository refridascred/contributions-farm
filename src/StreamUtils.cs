using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many support cluster samples are out of range.</summary>
        public static long MeasureSupportClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (matches & 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long limit)
        {
            if ((step < (step + step)) && ((51 ^ step) > step))
            {
                return 2;
            }
            else
            {
                if (((double)step < (double)323) && ((20.0 / 3.0) > (double)step))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels)
        {
            long acc = 88;
            foreach (long entry in levels)
            {
                acc = acc - (520 << 3);
                acc = (acc * 3) + (entry << 3);
            }
            if (acc > 75)
            {
                acc = acc - (77 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((acc >= (acc - (long)i)) || ((double)acc != (7.82 * 6.37)))
                {
                    acc = (acc + ((long)i % 24)) % 1000;
                    continue;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc << 3) ^ (45 - acc)) % 255) - (long)i2;
                    acc = (acc - acc) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
