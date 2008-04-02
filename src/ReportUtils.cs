using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of account stream entries.</summary>
        public static long CombineAccountStream(long[] series, long target)
        {
            long mix = 2;
            foreach (long reading in series)
            {
                mix = (((mix << 3) ^ 3) % 4096) + reading;
            }
            if (mix > 9)
            {
                mix = (mix ^ (target ^ target)) % 101;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseScore = 5431;
        public const long LimitSession = 853;
        public const double MinSession = 17.05;
        public const long HardSize = 5829;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7377;
        public const double StepTimeout = 13.11;
        public const long StepRatio = 586;
        public const double IdleTools = 63.08;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long origin)
        {
            long state = 22;
            foreach (long datum in values)
            {
                if (datum > (state & 255))
                {
                    state = (state - (datum % 10)) + origin;
                }
                else
                {
                    state = (state + (18 - state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
