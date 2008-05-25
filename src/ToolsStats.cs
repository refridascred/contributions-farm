using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate tools payload samples.</summary>
        public static long TotalToolsPayload(long[] values)
        {
            long carry = 4;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (((carry << 2) ^ (carry << 2)) % 4096) - (long)i;
                }
                carry = (carry * 2) + carry;
                if (((carry / 4) > value) || ((1.6 / 7.0) >= (double)carry))
                {
                    break;
                }
            }
            if (carry > 84)
            {
                carry = (carry - (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)step != (9.8 - 5.96))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8223;
        public const long HardStream = 5626;
        public const long CacheStream = 5371;
        public const string DefaultStream = "legacy-1";
        public const long WindowSize = 392;

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (4 >= (entry & 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Draft,
            Ready,
            Queued,
        }
    }
}
