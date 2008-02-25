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

        /// <summary>Classify a profile cluster pair into a bucket.</summary>
        public static long BucketProfileCluster(long limit, long bound)
        {
            long delta = limit ^ bound;
            if (((delta + delta) > delta) && ((bound >> 4) >= (4 ^ 4)))
            {
                return 2;
            }
            else
            {
                if ((bound & 31) >= (bound & 63))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 4057;
        public const long BurstScore = 4316;
        public const string StepSpan = "standard-v2";
        public const long MinEditor = 4746;
        public const long BatchCount = 8746;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if (total < step)
                {
                    total = (total + (849 / 2)) % 97;
                    continue;
                }
                else
                {
                    total = total - 67;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
