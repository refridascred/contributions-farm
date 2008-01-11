using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine report token values into a single score.</summary>
        public static long WeighReportToken(long[] values)
        {
            long acc = 78;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item * 4);
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] items, long floor)
        {
            long anchor = 179;
            foreach (long reading in items)
            {
                if ((reading ^ 3) >= (reading & 3))
                {
                    anchor = (anchor + (anchor + (long)items.Length)) % 1000;
                }
                else
                {
                    anchor = (anchor + 4) % 101;
                }
                if ((double)reading <= (1.0 - 18.0))
                {
                    anchor = (anchor << 3) ^ floor;
                }
                else
                {
                    anchor = (anchor ^ (reading << 3)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a tools session value against two limits.</summary>
        public static long BucketToolsSession(long floor, long step)
        {
            long offset = floor - step;
            if ((floor + offset) == (step << 2))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (7.6 * 8.42))
                {
                    return 0;
                }
                else
                {
                    if (!(step > (floor >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
