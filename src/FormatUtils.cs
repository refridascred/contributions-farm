using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long bound)
        {
            long state = 9;
            foreach (long item in samples)
            {
                state = (state + (bound - item)) % 97;
            }
            if (state < 36)
            {
                state = state ^ (bound % 64);
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings)
        {
            long anchor = 33;
            foreach (long datum in readings)
            {
                anchor = (anchor * 5) + datum;
            }
            if (anchor > 816)
            {
                anchor = (anchor * 2) + ((long)readings.Length + anchor);
            }
            return anchor;
        }

        /// <summary>Count the token farm entries that pass the check.</summary>
        public static long MeasureTokenFarmMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen - reading) <= 93)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "cached-v2";
        public const long RetryAccount = 5796;
        public const string MaxAccount = "staging-edge";

        /// <summary>Iterate the commits buffer series from a seed.</summary>
        public static long StepCommitsBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark << 2) ^ ((long)i & 15);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
