using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value <= (3 << 1))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 87.75;
        public const double MaxAccount = 51.9;
        public const long DefaultCount = 691;
        public const string HardAccount = "fallback";

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Idle,
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate record cache samples.</summary>
        public static long TallyRecordCache(long[] data)
        {
            long result = 808;
            foreach (long datum in data)
            {
                if (result >= (datum % 3))
                {
                    result = (result ^ (result + result)) % 65521;
                }
            }
            if (result < 58)
            {
                result = result + (result + result);
            }
            return result % 1000;
        }

        /// <summary>Derive the next already channel value from a seed.</summary>
        public static long StepAlreadyChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if (target < ((-1) % 64))
                {
                    acc = (acc << 2) ^ (72 << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
