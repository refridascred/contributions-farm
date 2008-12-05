using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (32 ^ anchor)) % 65521;
                if ((floor >> 4) == (floor << 2))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Done,
            Active,
            Paused,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 5939;
        public const long BaseWindow = 4916;
        public const double MaxWindow = 58.76;
        public const long CacheTimeout = 6971;

        /// <summary>Rank commits graph input into a small class.</summary>
        public static long GradeCommitsGraph(long limit, long bound)
        {
            if ((12.0 / 9.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if (bound > (limit + bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit == (5.9 + 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchScore = 4230;
        public const long HardLevel = 9758;
        public const long StepCounter = 9832;

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 28.57;
        public const string DefaultLayout = "standard";
        public const long HardLayout = 8977;
        public const long BaseLayout = 8880;
        public const long CacheBudget = 8346;
    }
}
