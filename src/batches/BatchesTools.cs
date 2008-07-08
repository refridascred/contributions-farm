using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 18;
            foreach (long sample in series)
            {
                if ((0 > acc) || ((sample >> 5) < (sample >> 2)))
                {
                    acc = (acc << 3) ^ (8 & 1);
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ acc) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Paused,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long AuditRecordCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((-92) + seen) > reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
