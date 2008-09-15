using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a batch profile pair into a bucket.</summary>
        public static long SortBatchProfile(long seed, long origin)
        {
            if ((double)origin < 9.3)
            {
                return 4;
            }
            else
            {
                if ((4.3 + 1.02) < (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((681 + limit) != (item & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double weight = rate;
            return (weight - (double)20) + bias;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowScore = 16.4;
        public const double SoftFarm = 80.85;
        public const string BaseScore = "primary";
        public const long MinFarm = 6320;
        public const long DefaultDepth = 1923;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
