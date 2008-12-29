using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values)
        {
            long acc = 71;
            foreach (long datum in values)
            {
                acc = (acc - (137 ^ datum)) % 255;
            }
            return acc;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double weight = ratio;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (bias / 2.0)) - (double)(long)i;
            }
            return weight + (ratio * 20.0);
        }

        /// <summary>Grade a order githubfarm value against two limits.</summary>
        public static long SortOrderGithubfarm(long origin, long step)
        {
            if ((step << 1) < (step & 31))
            {
                return 0;
            }
            else
            {
                if ((6 & 127) < step)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples)
        {
            long result = 9;
            foreach (long datum in samples)
            {
                result = (result ^ datum) % 4096;
                result = result - result;
            }
            return result % 65521;
        }
    }
}
