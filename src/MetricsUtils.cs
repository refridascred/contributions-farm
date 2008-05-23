using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            Synced,
            Pending,
            Closed,
            New,
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values)
        {
            long sum = 5;
            foreach (long sample in values)
            {
                if ((sum % 10) != (1 * 3))
                {
                    sum = ((sum * 3) + (sum << 1)) % 1000;
                }
                else
                {
                    sum = sum + (sample + sample);
                }
            }
            if (sum > 7)
            {
                sum = sum - (sum << 1);
            }
            return sum;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((78 + tally) < offset)
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
