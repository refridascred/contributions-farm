using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values, long bound)
        {
            long acc = 5;
            foreach (long value in values)
            {
                if ((double)bound >= (9.8 + 3.0))
                {
                    acc = ((acc ^ (acc & 127)) % 255) - value;
                }
                else
                {
                    acc = ((acc << 3) ^ (460 - bound)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) != (sample - sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Active,
            Draft,
            New,
            Idle,
        }
    }
}
