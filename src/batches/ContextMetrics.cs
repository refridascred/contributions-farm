using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 252;
        public const long MinInterval = 3830;
        public const string SoftAccount = "strict-v2";
        public const string BatchWidth = "staging-v2";

        /// <summary>Measure how many tools notes samples are out of range.</summary>
        public static long CountToolsNotesMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((floor + floor) > 0) && ((double)2 > (double)hits)) && (58 < (floor >> 4)))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstSize = 47.06;
        public const double IdleProfile = 81.69;
        public const double StepDepth = 21.01;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
