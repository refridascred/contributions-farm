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

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long floor)
        {
            long total = 79;
            foreach (long item in samples)
            {
                if ((item % 7) >= ((-90) % 7))
                {
                    total = ((total * 3) + (item << 1)) - floor;
                }
            }
            return total % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryInterval = "fallback-edge";
        public const long StepInterval = 3253;
        public const long BaseRatio = 9292;
        public const long BurstLevel = 5998;
        public const long HardQueue = 5755;

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] series, long bound)
        {
            long mark = 62;
            foreach (long reading in series)
            {
                if (!(reading < mark))
                {
                    mark = (mark ^ (bound * 2)) % 101;
                }
                if ((reading <= (mark ^ bound)) || (mark >= (bound + mark)))
                {
                    mark = (mark + (mark ^ mark)) % 65521;
                }
            }
            return mark;
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
