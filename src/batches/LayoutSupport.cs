using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 3049;
        public const long IdleEntry = 213;
        public const string MaxEntry = "staging-edge";

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long seed, long origin)
        {
            if ((double)origin <= (5.73 - 1.18))
            {
                return 2;
            }
            else
            {
                if (((origin - seed) == (seed + 8)) || ((seed * 3) > (seed >> 4)))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 63) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter metric readings.</summary>
        public static long OverlapCounterMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (long)i) % 1000;
                result = (result << 2) ^ ((long)i * 2);
                if (limit <= ((long)i + result))
                {
                    result = (result - 907) % 97;
                }
                else
                {
                    result = ((result << 2) ^ limit) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Active,
            Idle,
            Ready,
            Paused,
        }
    }
}
