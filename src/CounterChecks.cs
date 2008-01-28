using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool GuardCommitsBufferBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits * 5) >= origin)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Roll a layout stats counter forward.</summary>
        public static long StepLayoutStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!(306 <= (acc + acc)))
                {
                    acc = (acc * 4) + (offset & 15);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Pending,
            Draft,
            Failed,
        }
    }
}
