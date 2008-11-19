using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (949 > seen)
                {
                    seen = ((seen + 3) - datum) - origin;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((8.1 * 7.0) < (double)datum) && ((1.0 / 9.0) >= (4.26 / 7.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the session record series from a seed.</summary>
        public static long StepSessionRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ 436) % 97) + (long)i2;
                    mix = (mix << 2) ^ mix;
                }
                mix = ((mix << 2) ^ (mix + offset)) % 4096;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
