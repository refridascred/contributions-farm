using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long seed)
        {
            if ((seed - seed) < (seed + (-218)))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (double)step)
                {
                    return 3;
                }
                else
                {
                    if (((23 + 860) >= (seed % 3)) && ((seed + seed) <= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
