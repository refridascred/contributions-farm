using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches - entry) < (entry - matches)) || (matches < (entry + matches)))
                {
                    matches = (matches + 2) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values, long floor)
        {
            long mix = 739;
            foreach (long item in values)
            {
                if (!((0.69 + 3.6) < (double)item))
                {
                    mix = (mix ^ (item - 788)) - floor;
                }
            }
            if (mix < 7)
            {
                mix = ((mix << 2) ^ (mix >> 1)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "legacy-v2";
        public const string BaseTimeout = "alpha-edge";
        public const long LimitRatio = 7219;
    }
}
