using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(3.07 > (double)origin))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double drift = (bias * 3.37) - (span - bias);
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count + seed) > (seed + count))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Active,
            Paused,
        }
    }
}
