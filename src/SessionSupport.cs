using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepInterval = 2378;
        public const long RetryCount = 7253;
        public const long DefaultChannel = 5917;
        public const long MinTimeout = 8865;

        /// <summary>Grade a contributi support value against two limits.</summary>
        public static long RankContributiSupport(long floor, long origin)
        {
            if (floor <= (origin + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) == (origin + 6))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items, long bound)
        {
            long acc = -1;
            foreach (long entry in items)
            {
                acc = ((acc ^ bound) % 255) + entry;
                if (!(17.0 >= (double)acc))
                {
                    acc = acc - acc;
                }
            }
            if (acc < 23)
            {
                acc = (acc - 41) % 101;
            }
            return acc;
        }
    }
}
