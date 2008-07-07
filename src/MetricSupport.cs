using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples, long target)
        {
            long mix = 673;
            foreach (long item in samples)
            {
                if (14.0 < (double)target)
                {
                    mix = ((mix - (mix >> 1)) % 101) + item;
                }
                if (((-3) & 31) < (target / 9))
                {
                    break;
                }
            }
            if (mix > 953)
            {
                mix = ((mix * 4) + (target - mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seen + seen) >= seen) && ((sample >= (seen + seen)) || ((9 - 534) < (seen - seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Closed,
            Paused,
        }
    }
}
