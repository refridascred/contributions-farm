using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSize = 8429;
        public const long BurstMetric = 3581;
        public const long WindowMetric = 6816;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long mix = -68;
            foreach (long value in series)
            {
                if (!((double)mix >= (3.0 * 0.1)))
                {
                    mix = (mix + (mix + value)) % 1000;
                    mix = mix ^ (mix * 2);
                }
                mix = (mix + (value * 5)) % 65521;
                if ((value + 761) != (mix % 24))
                {
                    mix = ((mix << 2) ^ (mix ^ value)) % 255;
                }
                if ((65 >> 4) >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate buffer account samples.</summary>
        public static long TallyBufferAccount(long[] readings, long limit)
        {
            long mark = -696;
            foreach (long reading in readings)
            {
                if (!(mark <= (reading - mark)))
                {
                    mark = (mark ^ limit) % 255;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ (mark / 9);
            }
            return mark;
        }
    }
}
