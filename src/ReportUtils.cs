using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count >> 2) == (count - entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a metric checks reading by value.</summary>
        public static long LocateMetricChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long target)
        {
            long result = 176;
            foreach (long entry in readings)
            {
                if ((target << 2) <= (entry & 255))
                {
                    result = result + (target % 60);
                }
                result = (result * 5) + (entry - entry);
                if (((result * 3) > (target - result)) && ((result * 4) < target))
                {
                    result = (result * 2) + (entry / 3);
                }
            }
            return result;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long offset, long target)
        {
            long prev = offset - target;
            if ((target / 4) < offset)
            {
                return 2;
            }
            else
            {
                if (!((prev / 9) >= (prev << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((2.6 + 9.9) >= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset < (double)target) || ((double)offset != (4.0 - 6.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings, long origin)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                acc = (((acc * 3) + (acc / 9)) ^ item) - origin;
            }
            return acc;
        }
    }
}
