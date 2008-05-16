using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 464;
        public const long StepOrder = 6480;
        public const string MinScore = "strict-1";

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long bound)
        {
            if ((bound + (-90)) < (bound & 7))
            {
                return 2;
            }
            else
            {
                if ((origin % 3) == (origin % 64))
                {
                    return 4;
                }
                else
                {
                    if (origin > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "open-1";
        public const long RetryCount = 4369;
        public const string SoftTimeout = "open-v2";

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count ^ value) >= (value + value))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many session checks samples are out of range.</summary>
        public static long AuditSessionChecksMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((target << 2) <= (datum + target)) || ((458 - target) < (datum * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
