using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Closed,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Audit batch account readings against a rule.</summary>
        public static long AuditBatchAccountHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits > (reading + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit payload batch readings against a rule.</summary>
        public static long CountPayloadBatchOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (18.0 >= (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 833;
        public const long BaseWidth = 8688;
        public const long LimitSpan = 2469;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = (state + 63) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
