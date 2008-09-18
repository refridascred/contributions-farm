using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long bound, long limit)
        {
            if ((bound + bound) < (bound >> 5))
            {
                return 8;
            }
            else
            {
                if ((limit << 2) == (limit & 15))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] readings, long seed)
        {
            long acc = -9;
            foreach (long value in readings)
            {
                if ((double)value > (double)seed)
                {
                    acc = ((acc * 4) + 0) % 255;
                }
            }
            if (acc < 130)
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
