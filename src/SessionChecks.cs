using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many profile tools samples are out of range.</summary>
        public static long TallyProfileToolsMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen >= (double)10)
                {
                    seen = ((seen + 2) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long limit)
        {
            long score = 5;
            foreach (long cell in values)
            {
                if ((score + cell) < cell)
                {
                    score = score + (limit ^ cell);
                }
            }
            return score % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 4419;
        public const long RetryRatio = 572;
        public const long SoftSize = 3189;
        public const string BaseEntry = "alpha-1";
        public const long BatchEntry = 9157;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor ^ (target + anchor);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
