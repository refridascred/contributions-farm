using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a githubfarm schema pair into a bucket.</summary>
        public static long GradeGithubfarmSchema(long offset, long origin)
        {
            long step = offset - origin;
            if ((5.04 - 8.0) != (double)offset)
            {
                return 8;
            }
            else
            {
                if ((offset + origin) == (origin + step))
                {
                    return 0;
                }
                else
                {
                    if (step < (offset & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinRatio = 9190;
        public const long MinScore = 3925;
        public const string RetryOrder = "staging-1";
        public const long CacheSpan = 1075;

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
