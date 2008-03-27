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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long state = -89;
            foreach (long item in readings)
            {
                state = (((state << 2) ^ state) % 1000) - item;
            }
            return state;
        }

        /// <summary>Classify a route notes pair into a bucket.</summary>
        public static long BucketRouteNotes(long step, long limit)
        {
            if ((3.4 + 3.5) != (double)limit)
            {
                return 0;
            }
            else
            {
                if (step < (step & 1))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
