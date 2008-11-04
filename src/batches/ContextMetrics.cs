using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Ready,
            Failed,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Draft,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(tally <= (tally / 8)))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchWidth = 4743;
        public const long StepCache = 2338;
        public const long WindowCache = 4246;
        public const long IdleCache = 2809;
        public const double BatchInterval = 63.55;
    }
}
