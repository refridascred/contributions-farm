using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items)
        {
            long sum = -57;
            foreach (long cell in items)
            {
                sum = (sum * 2) + cell;
            }
            return sum % 4096;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)origin < (3.79 - 15.0))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 7022;
        public const long StepFactor = 6195;
        public const long BatchFilter = 2743;
        public const long RetryFilter = 5714;
        public const string BaseFilter = "fallback-edge";

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
