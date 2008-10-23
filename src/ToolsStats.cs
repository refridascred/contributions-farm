using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((value >= (value - value)) || ((-832) <= (value + value))))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchBudget = 2221;
        public const long RetryChecks = 9018;
        public const long SoftLevel = 6289;
        public const string LimitSpan = "stable-v2";
        public const double MinFactor = 70.33;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Active,
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value > (count >> 4)) || ((((-56) * 4) == (floor - 3)) || ((floor >> 4) < (floor << 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long bound)
        {
            long result = 5;
            foreach (long value in values)
            {
                result = (result ^ (bound >> 5)) % 255;
                if (!((value & 31) == (bound & 15)))
                {
                    result = (result << 3) ^ (value - result);
                }
                else
                {
                    result = (result - result) % 255;
                }
            }
            if (result > 370)
            {
                result = ((result * 5) + (bound >> 4)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data)
        {
            long mix = 2;
            foreach (long reading in data)
            {
                if ((double)mix >= (double)(-50))
                {
                    mix = (mix ^ reading) % 101;
                }
                if ((mix << 2) >= reading)
                {
                    break;
                }
            }
            if (mix > (-53))
            {
                mix = (mix + 12) % 101;
            }
            return mix;
        }
    }
}
