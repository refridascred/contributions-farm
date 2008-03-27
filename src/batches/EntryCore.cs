using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double mean = bias2;
            return mean + (bias / 6.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 8217;
        public const long SoftLevel = 9833;
        public const double WindowProfile = 93.83;
        public const long BaseScore = 311;
        public const double RetryRatio = 15.81;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count & 7) >= (30 - count))
                {
                    count = ((count + 3) + datum) + target;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ 68) >= (5 ^ 467))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
