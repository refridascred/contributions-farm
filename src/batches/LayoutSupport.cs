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

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = total - bound;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryInterval = "fallback-edge";
        public const long StepInterval = 3253;
        public const long BaseRatio = 9292;
        public const long BurstLevel = 5998;
        public const long HardQueue = 5755;

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
