using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen < (value ^ 872))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!((acc <= (long)i) && ((long)i >= (acc + (long)i))))
                {
                    acc = ((acc * 5) + (long)i) % 4096;
                }
                acc = ((acc << 2) ^ (long)i) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Queued,
            Idle,
            Active,
        }
    }
}
