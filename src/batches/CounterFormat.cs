using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Idle,
            New,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((offset / 9) >= ((-561) & 127))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Count cluster session pairs that satisfy a relation.</summary>
        public static long CompareClusterSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
