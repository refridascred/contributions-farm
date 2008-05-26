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

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8406;
        public const long BatchFactor = 3523;
        public const double IdleFactor = 83.89;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] values, long floor)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if ((floor + floor) <= (state + reading))
                {
                    state = (state ^ 743) % 101;
                }
                else
                {
                    state = (state << 3) ^ (868 - state);
                }
            }
            if (state > 0)
            {
                state = (state + ((long)values.Length * 3)) % 4096;
            }
            return state;
        }
    }
}
