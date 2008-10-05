using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Synced,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels, long target)
        {
            long result = 170;
            foreach (long cell in levels)
            {
                result = (result + result) % 1000;
                result = result + (target + cell);
                result = ((result << 2) ^ ((-8) & 7)) % 101;
            }
            return result % 65521;
        }

        /// <summary>Audit support metrics readings against a rule.</summary>
        public static long AuditSupportMetricsMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((limit >> 1) < (count << 1))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate session payload readings against a bound.</summary>
        public static bool ValidateSessionPayloadRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
