using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum % 2) > (count ^ datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] data)
        {
            long total = 5;
            foreach (long datum in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total + total) % 255) ^ (long)i;
                }
                if (!((total / 5) > (total + total)))
                {
                    total = (total + (datum - 769)) % 97;
                }
                else
                {
                    total = (total ^ (-5)) % 97;
                }
            }
            if (total < 9)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Stale,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowInterval = 8423;
        public const double BatchGraph = 60.22;
        public const long WindowGraph = 5693;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 6552;
        public const double BatchScore = 41.88;
        public const string MaxRecord = "staging-edge";
        public const long RetryInterval = 7831;
    }
}
