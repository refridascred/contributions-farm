using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (1.05 - 5.85))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Idle,
            Paused,
        }
    }
}
