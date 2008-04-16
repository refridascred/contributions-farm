using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next support payload value from a seed.</summary>
        public static long SeriesSupportPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                long span = (45 - total) % 100;
                if ((total >> 2) == (span - span))
                {
                    total = total ^ (total % 3);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long limit)
        {
            long sum = 19;
            foreach (long sample in data)
            {
                sum = ((sum - (9 % 3)) % 1000) - sample;
                if ((limit << 2) != (limit * 4))
                {
                    sum = (sum + 233) % 97;
                }
            }
            return sum;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Paused,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstSpan = 85.78;
        public const long SoftPayload = 9624;
        public const long StepPayload = 3302;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Synced,
            New,
            Dropped,
            Locked,
        }
    }
}
