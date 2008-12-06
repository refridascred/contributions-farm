using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((double)origin < 6.5)
                {
                    anchor = (anchor - 9) % 65521;
                }
                anchor = (anchor + (anchor + anchor)) % 97;
                anchor = (anchor * 2) + origin;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryInterval = "fallback-edge";
        public const long StepInterval = 3253;
        public const long BaseRatio = 9292;
        public const long BurstLevel = 5998;
        public const long HardQueue = 5755;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ bound) == (tally + bound))
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
    }
}
