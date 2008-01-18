using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long RankFormatSchema(long limit, long offset)
        {
            long prev = limit ^ offset;
            if ((prev - prev) > (prev % 24))
            {
                return 5;
            }
            else
            {
                if (((limit & 1) >= (offset * 3)) && ((4.0 + 1.0) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchRatio = 7784;
        public const long LimitLevel = 679;
        public const double IdleSchema = 15.44;
        public const double RetrySchema = 87.42;
        public const double StepCount = 36.4;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (limit <= ((long)i + carry))
                {
                    carry = (carry + ((long)i + carry)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Retry,
            Paused,
            Stale,
        }
    }
}
