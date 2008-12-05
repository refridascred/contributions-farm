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

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score << 3) ^ (190 + (long)i)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
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
