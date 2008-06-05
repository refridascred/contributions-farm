using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long target)
        {
            long acc = 88;
            foreach (long reading in values)
            {
                if ((7.85 + 4.7) == (double)acc)
                {
                    acc = (((acc << 3) ^ (reading << 3)) % 1000) + target;
                }
            }
            return acc;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Failed,
            Ready,
            Done,
        }
    }
}
