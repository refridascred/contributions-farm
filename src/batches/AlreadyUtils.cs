using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long AuditBatchEditorHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((double)seen > (1.7 * 2.3)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Active,
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long limit, long step)
        {
            if ((double)step < (3.4 * 4.95))
            {
                return 0;
            }
            else
            {
                if (!(step >= (limit ^ step)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step >= 6.3)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((seen - step) == (long)readings.Length))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }
    }
}
