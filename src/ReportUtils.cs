using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitSpan = "fallback";
        public const long MaxBudget = 8409;
        public const string LimitLevel = "strict-1";
        public const string IdleRatio = "local-edge";
        public const long MaxBuffer = 2841;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading % 3) < (reading * 2))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Count the filter account entries that pass the check.</summary>
        public static long AuditFilterAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((6 >> 4) > (hits >> 5))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload farm samples.</summary>
        public static long TallyPayloadFarm(long[] series)
        {
            long mix = 3;
            foreach (long value in series)
            {
                if ((double)mix != (7.89 * 3.5))
                {
                    mix = ((mix * 4) + (-14)) % 4096;
                }
                if ((3.02 / 2.0) != (double)mix)
                {
                    mix = ((mix * 4) + (98 - value)) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (5 % 60)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Retry,
            Pending,
            Done,
            Closed,
        }
    }
}
