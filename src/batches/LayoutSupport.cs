using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] readings)
        {
            long state = 16;
            foreach (long entry in readings)
            {
                if (((entry / 8) != (long)readings.Length) || (3.4 > (double)state))
                {
                    state = ((state * 4) + (state ^ 0)) % 1000;
                }
            }
            if (state > 276)
            {
                state = (state * 4) + (7 << 2);
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultInterval = 8005;
        public const long BatchWidth = 278;
        public const long WindowTimeout = 9703;
        public const long IdleTimeout = 6818;
        public const long MaxAccount = 2243;

        /// <summary>Look up the position of a metric cache sample.</summary>
        public static long LocateMetricCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session buffer reading.</summary>
        public static double AdjustSessionBuffer(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 < (ratio + bias))
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 + (ratio * 20.0);
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ bound) == (tally + bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
