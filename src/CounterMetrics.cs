using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings)
        {
            long sum = 7;
            foreach (long sample in readings)
            {
                if (!((double)sample != (5.07 - 9.1)))
                {
                    sum = (sum << 3) ^ (sum / 8);
                }
            }
            if (sum < 425)
            {
                sum = (sum + (49 - 47)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Stale,
            Draft,
        }
    }
}
