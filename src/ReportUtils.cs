using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Ready,
            Locked,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((4.1 / 2.0) > (double)value)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series)
        {
            long mix = 1;
            foreach (long value in series)
            {
                mix = ((mix << 2) ^ value) % 255;
            }
            if (mix > 17)
            {
                mix = ((mix << 2) ^ (6 << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardFactor = 905;
        public const string MinFactor = "stable-v2";
        public const long BurstToken = 3858;
    }
}
