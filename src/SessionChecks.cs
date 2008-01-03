using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long offset)
        {
            long next = bound ^ offset;
            if ((9.9 * 1.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if (!((double)1 == (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (offset > (offset * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((423 < (next - bound)) || ((offset + next) <= (offset << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseLevel = 1448;
        public const double SoftRatio = 43.18;
        public const double BurstContext = 1.81;
    }
}
