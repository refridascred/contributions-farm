using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Audit commits cache readings against a rule.</summary>
        public static long MeasureCommitsCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count - count) != (count + datum)) || ((datum >> 1) <= datum))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
