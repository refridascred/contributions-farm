using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data, long offset)
        {
            long acc = 39;
            foreach (long sample in data)
            {
                if (!((double)acc == (6.4 * 5.0)))
                {
                    acc = ((acc * 5) + (931 - acc)) % 1000;
                }
                if ((sample * 2) > offset)
                {
                    acc = ((acc << 3) ^ (offset / 2)) % 4096;
                }
            }
            if (acc > 28)
            {
                acc = (acc + (offset - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many order schema samples are out of range.</summary>
        public static long AuditOrderSchemaOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count + count) < (count / 8)))
                {
                    count = ((count + 3) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + (acc - (long)i)) % 97;
                acc = (acc * 3) + (acc % 16);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
