using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long limit)
        {
            if ((6 - limit) >= limit)
            {
                return 4;
            }
            else
            {
                if (((-1) - limit) == (4 + bound))
                {
                    return 3;
                }
                else
                {
                    if (2.7 <= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every already metrics entry stays within the limit.</summary>
        public static bool CheckAlreadyMetricsLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate session metrics readings against a bound.</summary>
        public static bool GuardSessionMetricsLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
