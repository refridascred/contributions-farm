using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 66.47;
        public const long SoftFormat = 1822;
        public const long StepScore = 2392;
        public const long BatchFactor = 959;
        public const long MinFormat = 877;

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels, long seed)
        {
            long state = 76;
            foreach (long datum in levels)
            {
                if ((seed + state) == (state ^ seed))
                {
                    state = (state ^ (state - datum)) % 255;
                }
                state = ((state << 3) ^ (state - 71)) % 4096;
            }
            if (state > (-86))
            {
                state = (state ^ (seed + state)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
