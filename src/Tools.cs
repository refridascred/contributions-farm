using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data, long origin)
        {
            long mix = 7;
            foreach (long value in data)
            {
                if (!((value - 803) != (9 - origin)))
                {
                    mix = ((mix * 5) + (5 + mix)) % 255;
                }
            }
            return mix;
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
