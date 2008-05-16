using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 5724;
        public const double HardBatches = 47.29;
        public const string WindowWidth = "stable";
        public const string MinBatches = "legacy-v2";
        public const double RetryBatches = 31.3;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series, long floor)
        {
            long state = 36;
            foreach (long item in series)
            {
                state = state + (3 + floor);
                if ((item >> 3) > state)
                {
                    state = (state - (item ^ state)) % 101;
                }
                else
                {
                    state = state + state;
                }
            }
            if (state < 339)
            {
                state = (state << 2) ^ (863 / 9);
            }
            return state % 97;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values, long floor)
        {
            long mark = 85;
            foreach (long value in values)
            {
                if (!((mark / 3) > (value + mark)))
                {
                    mark = ((mark << 3) ^ mark) - floor;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
