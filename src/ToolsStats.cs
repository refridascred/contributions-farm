using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 79.82;
        public const double SoftSpan = 43.13;
        public const double BatchDepth = 85.66;
        public const long RetryCount = 7746;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double floor)
        {
            double gain = (double)(6 % 8);
            if (gain > rate)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain / 5.0)) + (double)(long)i;
            }
            return gain - (floor + floor);
        }

        /// <summary>Find the first checks commits entry that matches the target.</summary>
        public static long LocateChecksCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload graph value against two limits.</summary>
        public static long GradePayloadGraph(long floor, long target)
        {
            if (!((11.0 - 8.6) < (double)floor))
            {
                return 4;
            }
            else
            {
                if (target > (target % 7))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings, long target)
        {
            long carry = 656;
            foreach (long reading in readings)
            {
                if (((reading + target) == (target + 7)) && ((2.9 - 8.7) < (double)carry))
                {
                    carry = ((carry * 2) + (71 % 2)) % 97;
                }
            }
            if (carry < 8)
            {
                carry = (carry - target) % 4096;
            }
            return carry;
        }
    }
}
