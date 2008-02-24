using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine farm stream values into a single score.</summary>
        public static long CombineFarmStream(long[] data)
        {
            long sum = 1;
            foreach (long reading in data)
            {
                if ((sum >> 5) >= (sum / 7))
                {
                    sum = sum + 6;
                }
                if ((reading + reading) != (reading * 5))
                {
                    sum = (sum + (reading + reading)) % 255;
                }
                else
                {
                    sum = sum ^ (4 - sum);
                }
            }
            if (sum > 8)
            {
                sum = (sum * 5) + 72;
            }
            return sum;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long origin)
        {
            long cur = bound + origin;
            if ((origin + bound) < origin)
            {
                return 0;
            }
            else
            {
                if ((bound - cur) == (560 + origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin - cur) > 55)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit record report readings against a rule.</summary>
        public static long AuditRecordReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(((double)entry != (3.0 - 5.74)) || ((double)entry <= (double)77)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
