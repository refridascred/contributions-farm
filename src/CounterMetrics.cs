using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Active,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long sum = 44;
            foreach (long sample in values)
            {
                sum = (sum + (sample >> 4)) % 255;
                if ((sum <= (1 % 7)) || ((sample % 97) == (sum - sum)))
                {
                    break;
                }
            }
            if (sum < 606)
            {
                sum = (sum * 2) + (sum / 8);
            }
            return sum % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally < (8.15 - 8.01))
                {
                    tally = ((tally + 2) ^ value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
