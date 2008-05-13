using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - hits) >= hits)
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel metric samples are out of range.</summary>
        public static long TallyChannelMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count & 63) < (count - (-3)))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate payload session samples.</summary>
        public static long CombinePayloadSession(long[] values, long origin)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if ((acc >> 4) > origin)
                {
                    acc = acc + (1 / 8);
                }
                else
                {
                    acc = (acc + (origin + item)) % 101;
                }
            }
            if (acc < 23)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Stale,
            Draft,
            Idle,
        }
    }
}
