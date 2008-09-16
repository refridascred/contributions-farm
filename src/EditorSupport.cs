using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "legacy";
        public const double HardSpan = 42.75;
        public const long WindowMetric = 1312;
        public const long RetryBudget = 7832;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count > (origin * 5))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Active,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Count session entry pairs that satisfy a relation.</summary>
        public static long MatchSessionEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
