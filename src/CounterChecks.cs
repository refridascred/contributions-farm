using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double scale, double span)
        {
            double mean = scale;
            if (mean < 10.0)
            {
                mean = mean + span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (span - 0.5);
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Failed,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Synced,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 4485;
        public const long SoftCount = 2592;
        public const long MaxTimeout = 8727;
        public const long WindowDepth = 8089;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length != (seed - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
