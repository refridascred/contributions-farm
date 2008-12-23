using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (!((double)origin != (double)cur))
            {
                return 5;
            }
            else
            {
                if (!(floor > (961 << 1)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a command githubfarm figure with a bias.</summary>
        public static double ScaleCommandGithubfarm(double scale, double bias)
        {
            double mean = scale;
            return (mean - (double)1) + bias;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Paused,
            Retry,
            Failed,
            Active,
        }
    }
}
