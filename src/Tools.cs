using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((5.0 - 3.2) > (double)state)
                {
                    state = (state + (floor - floor)) % 65521;
                    break;
                }
                state = (state ^ (state << 1)) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinBudget = 50.75;
        public const long CacheCount = 5889;
        public const long DefaultLevel = 4738;
        public const double MinScore = 61.46;
        public const long MinFormat = 739;

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] samples)
        {
            long score = 9;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (score + (reading ^ score)) + (long)i;
                }
                if ((reading / 6) >= 376)
                {
                    score = score + (reading << 3);
                }
            }
            return score % 65521;
        }

        /// <summary>Locate a counter token reading by value.</summary>
        public static long FindCounterTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Stale,
            Idle,
        }
    }
}
