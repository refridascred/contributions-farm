using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) == (matches + matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long offset, long floor)
        {
            if (offset < (offset << 1))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (3.5 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset > (3.3 * 11.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor & 1) <= (32 + floor)) && ((double)floor <= 10.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Draft,
            Paused,
            Queued,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheDepth = "alpha-edge";
        public const double SoftCount = 18.86;
        public const double SoftAlready = 75.72;
        public const string WindowAlready = "alpha-1";

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultWidth = 49.35;
        public const string LimitSize = "staging";
        public const double DefaultAlready = 79.67;
    }
}
