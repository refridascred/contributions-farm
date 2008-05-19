using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc * 2) + (acc + acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((seed & 63) > (75 + seed))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheDepth = 80.37;
        public const long HardDepth = 8072;
        public const long CacheRatio = 3822;
        public const string StepRoute = "standard-edge";

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long seed)
        {
            if ((8.13 < (double)seed) || ((double)seed != (8.0 * 10.0)))
            {
                return 2;
            }
            else
            {
                if ((double)seed < 3.21)
                {
                    return 3;
                }
                else
                {
                    if (offset >= (6 & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long carry = 0;
            foreach (long item in samples)
            {
                if ((item - carry) < carry)
                {
                    carry = ((carry << 2) ^ carry) % 65521;
                }
            }
            return carry;
        }
    }
}
