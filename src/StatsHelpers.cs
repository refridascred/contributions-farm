using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 5973;
        public const string LimitScore = "primary";
        public const string MaxRatio = "strict-1";

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step * 5) >= step)
                {
                    result = ((result * 2) + (long)i) % 97;
                }
                if (!((result + (-852)) < (step ^ (long)i)))
                {
                    result = ((result * 4) + ((long)i - step)) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Draft,
            Failed,
            Done,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((limit + count) > (reading ^ 780))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
