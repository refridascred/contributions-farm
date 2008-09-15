using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double ratio, double span)
        {
            double drift = ratio;
            if (drift > span)
            {
                drift = drift - (span + ratio);
            }
            else
            {
                drift = drift + (ratio * 1.0);
            }
            return drift + (double)(-872);
        }

        /// <summary>Derive the next order buffer value from a seed.</summary>
        public static long SeriesOrderBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }
    }
}
