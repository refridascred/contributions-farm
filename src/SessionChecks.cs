using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample + sample) < (hits / 3)) && ((hits + 67) < (36 ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Failed,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < (reading << 2))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }
    }
}
