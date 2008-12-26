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

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels)
        {
            long anchor = 53;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor ^ ((long)i - anchor)) % 101;
                }
                anchor = (anchor << 2) ^ (744 / 7);
                if (!((sample << 3) > sample))
                {
                    break;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor - (anchor * 2)) % 101;
            }
            return anchor;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
