using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next record report value from a seed.</summary>
        public static long SeriesRecordReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((limit - result) < (limit + (long)i))
                {
                    result = (result + (limit / 4)) % 101;
                    result = (result << 2) ^ (67 % 7);
                }
                if (limit <= (limit / 6))
                {
                    result = ((result << 2) ^ ((long)i & 255)) % 97;
                    continue;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((5 % 100) < (count & 127)) && ((seed - 831) >= (count * 2))) || ((count >> 4) <= sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "stable-1";
        public const long HardSize = 8383;
        public const string HardAlready = "legacy";

        /// <summary>Check that every channel checks entry stays within the limit.</summary>
        public static bool VerifyChannelChecksBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
