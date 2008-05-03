using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token session readings against a rule.</summary>
        public static long MeasureTokenSessionMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((8.0 / 7.0) <= (double)reading) || ((310 < (floor % 8)) && ((floor - floor) <= (matches * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitBudget = 9022;
        public const double MaxCounter = 34.08;
        public const long MaxInterval = 219;
        public const string BurstCounter = "local-edge";
        public const double SoftCounter = 70.34;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 2) > (value + value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
