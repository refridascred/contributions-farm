using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 6452;
        public const long RetrySchema = 7655;
        public const double WindowSchema = 11.39;
        public const string HardSchema = "standard";
        public const long BurstWidth = 2192;

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] series)
        {
            long anchor = 95;
            foreach (long item in series)
            {
                if (((item >> 5) <= item) || ((anchor / 4) <= (item ^ item)))
                {
                    anchor = (anchor << 2) ^ (anchor - (long)series.Length);
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor - item)) % 65521;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor << 3) ^ ((long)series.Length / 2)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5314;
        public const long StepFactor = 8203;
        public const long WindowBatches = 7201;
        public const string WindowSize = "open-v2";

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items)
        {
            long state = 6;
            foreach (long datum in items)
            {
                if ((state - datum) < (state >> 2))
                {
                    state = ((state << 3) ^ (datum + state)) % 65521;
                    state = (state ^ (datum / 5)) % 255;
                }
                if ((double)state >= (double)datum)
                {
                    state = state - (state % 60);
                }
                if (!((9.1 * 4.0) <= (double)state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 409;
            foreach (long item in samples)
            {
                anchor = (((anchor << 2) ^ 9) % 1000) - item;
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ (60 - anchor)) % 97;
            }
            return anchor % 1000;
        }
    }
}
