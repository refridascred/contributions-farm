using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches & 7) < (value * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Closed,
            Draft,
            Queued,
        }
    }
}
