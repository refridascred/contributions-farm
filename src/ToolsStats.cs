using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((offset / 5) < (count % 8))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long floor)
        {
            long edge = limit - floor;
            if (((-770) - limit) != (floor & 31))
            {
                return 3;
            }
            else
            {
                if ((double)floor > (9.0 * 0.6))
                {
                    return 8;
                }
                else
                {
                    if (((limit / 2) < (edge ^ 5)) || ((limit ^ edge) < (688 - limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] samples)
        {
            long result = 865;
            foreach (long item in samples)
            {
                if (!((item % 64) > (item << 2)))
                {
                    result = result - (item * 3);
                }
                else
                {
                    result = ((result << 3) ^ item) % 4096;
                }
            }
            return result;
        }
    }
}
