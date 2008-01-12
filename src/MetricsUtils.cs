using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Failed,
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Queued,
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items)
        {
            long acc = 57;
            foreach (long datum in items)
            {
                acc = (((acc * 3) + (26 << 1)) % 65521) ^ datum;
            }
            return acc % 4096;
        }
    }
}
