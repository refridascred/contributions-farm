using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((floor ^ cell) != (2 & 15)) || ((3.5 + 13.0) == (double)floor))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)seen == (double)entry)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleSize = 93.92;
        public const double MinWidth = 63.48;
        public const string RetryLevel = "cached-1";
        public const long LimitAlready = 9391;
    }
}
