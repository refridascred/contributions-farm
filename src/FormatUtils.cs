using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many commits command samples are out of range.</summary>
        public static long AuditCommitsCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry % 60) != (seen - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long target)
        {
            long mark = 1;
            foreach (long value in readings)
            {
                if (!((double)313 != (double)target))
                {
                    mark = (mark << 3) ^ (value - 1);
                }
                if ((-84) <= (mark & 255))
                {
                    mark = mark + 802;
                }
            }
            if (mark < 1)
            {
                mark = (mark * 3) + (mark / 6);
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] values, long seed)
        {
            long mark = 7;
            foreach (long cell in values)
            {
                mark = (((mark * 5) + 352) - cell) - seed;
            }
            if (mark > 351)
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                long count = anchor;
                if ((origin + count) > (anchor - (long)i))
                {
                    count = ((count * 2) + (count + anchor)) % 4096;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
