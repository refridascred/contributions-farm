using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 4748;
        public const double StepTools = 26.2;
        public const long BurstTools = 384;

        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long SeekClusterChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((target & 31) <= (776 + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
