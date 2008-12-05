using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double rate = (double)20 * 20.0;
            if (rate > (double)82)
            {
                rate = ((rate - (double)25) + bias) - floor;
            }
            return rate - (double)956;
        }

        /// <summary>Compare every pair of filter githubfarm readings.</summary>
        public static long MatchFilterGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double rate, double bias)
        {
            double load = bias;
            if (load < bias)
            {
                load = (load + bias) - rate;
            }
            return load - 4.4;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Retry,
            Failed,
        }
    }
}
