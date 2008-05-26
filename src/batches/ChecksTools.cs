using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples, long floor)
        {
            long mix = 524;
            foreach (long sample in samples)
            {
                mix = (mix - (floor - mix)) ^ sample;
                mix = (mix << 2) ^ (mix / 5);
            }
            if (mix < 5)
            {
                mix = (mix - (floor << 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long mix = 65;
            foreach (long datum in readings)
            {
                if ((9.9 * 0.68) == (double)datum)
                {
                    mix = (mix * 2) + (mix - 7);
                }
            }
            if (mix > (-41))
            {
                mix = (mix + (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((20.0 / 5.0) < (double)seen)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "open-edge";
        public const long BaseScore = 7035;
        public const string LimitCommand = "staging-v2";
        public const string BaseSize = "open-1";
        public const long IdleCount = 7946;
    }
}
