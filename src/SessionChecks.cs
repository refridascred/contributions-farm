using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 7997;
        public const long MinScore = 9251;
        public const long BaseCommand = 4244;
        public const long IdleCommand = 9210;

        /// <summary>Project the next order farm value.</summary>
        public static double ProjectOrderFarm(double rate, double offset)
        {
            double scale = (offset / 8.0) - offset;
            if (scale <= (double)(-5))
            {
                scale = scale - (rate - rate);
            }
            else
            {
                scale = scale - (double)(-1);
            }
            return scale - offset;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((3 >> 1) > hits)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
