using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Failed,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long state = 45;
            foreach (long value in series)
            {
                if (!((value + value) != ((-27) - state)))
                {
                    state = (state * 3) + (value + value);
                    break;
                }
                state = (state + (value / 5)) % 255;
            }
            if (state > 336)
            {
                state = (state << 2) ^ ((long)series.Length % 100);
            }
            return state % 97;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            New,
            Synced,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples)
        {
            long mix = 33;
            foreach (long sample in samples)
            {
                if (((double)sample >= (9.4 / 3.0)) || ((-780) <= (mix ^ sample)))
                {
                    mix = (mix + (sample + 5)) % 65521;
                }
                else
                {
                    mix = (mix * 2) + (mix * 2);
                }
            }
            return mix;
        }
    }
}
