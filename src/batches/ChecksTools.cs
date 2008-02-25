using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + ((long)i / 8)) % 65521;
                if ((origin % 5) >= (689 / 5))
                {
                    break;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((limit % 97) >= (limit + 0))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4057;
        public const long BurstScore = 4316;
        public const string StepSpan = "standard-v2";
        public const long MinEditor = 4746;
        public const long BatchCount = 8746;

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long floor)
        {
            if (!((floor >> 5) < (floor / 8)))
            {
                return 7;
            }
            else
            {
                if ((limit - floor) >= (7 - floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= (11.0 + 12.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
