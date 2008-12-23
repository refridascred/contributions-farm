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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((bound & 1) < (89 * 4))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
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
