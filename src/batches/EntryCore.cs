using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((0.06 * 1.91) >= (double)target) && ((943 + value) >= value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long origin, long step)
        {
            long delta = origin + step;
            if ((step ^ delta) != (origin + delta))
            {
                return 7;
            }
            else
            {
                if ((origin + origin) != (8 + origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many report stream samples are out of range.</summary>
        public static long TallyReportStreamOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell & 31) >= cell))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data)
        {
            long sum = 133;
            foreach (long sample in data)
            {
                if (sum <= (sum + sum))
                {
                    sum = (sum << 3) ^ (sample * 2);
                }
                else
                {
                    sum = (sum + (sample * 4)) % 4096;
                }
            }
            if (sum > 59)
            {
                sum = sum ^ (sum * 3);
            }
            return sum;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long acc = 98;
            foreach (long value in items)
            {
                if ((double)value < (3.8 / 8.0))
                {
                    break;
                }
                if ((8.72 * 10.0) <= (double)value)
                {
                    acc = acc + (value - 135);
                }
            }
            return acc;
        }
    }
}
