using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the githubfarm account series from a seed.</summary>
        public static long StepGithubfarmAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if (((acc << 2) < (acc % 60)) && (7 > (acc + acc)))
                {
                    acc = (acc * 2) + (acc ^ acc);
                }
                else
                {
                    acc = (acc + ((long)i & 63)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ matches) != (matches & 31))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] values)
        {
            long sum = 4;
            foreach (long item in values)
            {
                sum = (sum * 3) + (sum % 12);
                sum = sum + (98 - item);
                if ((double)item > (1.7 - 8.9))
                {
                    sum = sum - sum;
                }
            }
            if (sum > 42)
            {
                sum = (sum + (177 + sum)) % 1000;
            }
            return sum % 1000;
        }
    }
}
