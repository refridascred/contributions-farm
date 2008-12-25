using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (2.6 * 6.0))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Active,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double weight = floor - 1.0;
            if (weight < floor)
            {
                weight = (weight - 4.96) - gain;
            }
            return weight - weight;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)origin <= (8.2 - 9.85))
                {
                    seen = (seen + 3) + value;
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
