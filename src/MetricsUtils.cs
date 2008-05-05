using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Failed,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) < datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long target)
        {
            if (((target << 2) >= target) && ((target << 1) >= limit))
            {
                return 6;
            }
            else
            {
                if (limit < (limit / 6))
                {
                    return 1;
                }
                else
                {
                    if ((1 << 3) > (target + 61))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 1863;
        public const long DefaultContributi = 4411;
        public const long MinContributi = 1535;
        public const string MinSpan = "latest-v2";
        public const string HardContributi = "alpha-edge";

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] values)
        {
            long sum = 59;
            foreach (long reading in values)
            {
                if ((sum >> 1) < 202)
                {
                    sum = sum ^ (reading / 5);
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 4096;
                }
            }
            return sum;
        }
    }
}
