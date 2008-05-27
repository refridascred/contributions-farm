using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((target % 24) < (target - sample)) || ((hits >> 3) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = ratio;
            if (drift >= 0.2)
            {
                drift = drift - 6.98;
            }
            else
            {
                drift = drift + (9.7 + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift - offset)) + (double)(long)i;
            }
            return drift - (double)3;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Draft,
            Dropped,
        }
    }
}
