using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool ValidateChecksRecordRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values, long step)
        {
            long total = -38;
            foreach (long datum in values)
            {
                total = ((total ^ (datum % 60)) % 65521) - step;
            }
            if (total > 6)
            {
                total = (total + 1) % 255;
            }
            return total;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long floor, long floor2)
        {
            long prev = floor ^ floor2;
            if (((prev * 4) < (855 * 5)) && ((double)4 > (double)floor))
            {
                return 7;
            }
            else
            {
                if (!((double)floor != (13.0 + 9.8)))
                {
                    return 2;
                }
                else
                {
                    if ((0.5 + 18.0) > (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
