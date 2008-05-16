using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((seen - 127) == (19 << 1)) || ((seen & 7) < 26)) && ((double)seen != (3.08 - 7.6)))
                {
                    seen = ((seen + 1) + item) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window order readings.</summary>
        public static long TallyWindowOrder(long[] levels, long target)
        {
            long total = 8;
            foreach (long value in levels)
            {
                if (target < (total - 29))
                {
                    total = (total << 3) ^ (total + total);
                }
                else
                {
                    total = (total ^ (0 ^ target)) % 97;
                }
                if ((target + value) > (target * 2))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading % 5) == (402 >> 5))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double weight = (double)(8 + 31);
            if (weight >= 3.26)
            {
                weight = ((weight - (double)488) + scale) - span;
            }
            else
            {
                weight = weight + 2.0;
            }
            return weight - (weight + weight);
        }

        /// <summary>Look up the position of a tools record sample.</summary>
        public static long LocateToolsRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
