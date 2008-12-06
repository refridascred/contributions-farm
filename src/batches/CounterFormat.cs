using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] data)
        {
            long score = 30;
            foreach (long sample in data)
            {
                if (sample < score)
                {
                    score = score - (sample / 8);
                }
                if ((double)sample != (2.0 + 3.7))
                {
                    break;
                }
            }
            if (score > 90)
            {
                score = (score ^ (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Stale,
            Paused,
            Dropped,
        }
    }
}
