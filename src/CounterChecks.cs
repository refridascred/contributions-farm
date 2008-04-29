using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items)
        {
            long acc = 30;
            foreach (long datum in items)
            {
                acc = (((acc * 2) + acc) % 255) ^ datum;
            }
            return acc;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Paused,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Closed,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((long)samples.Length != (64 ^ target))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double weight, double bias)
        {
            double rate = (double)1;
            if (rate < (bias + bias))
            {
                rate = rate + (5.1 / 6.0);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (bias - bias)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
