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

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 910;
        public const long BatchBudget = 8231;
        public const string CacheNotes = "alpha-edge";
        public const string DefaultScore = "stable";
        public const long MinDepth = 5567;

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
