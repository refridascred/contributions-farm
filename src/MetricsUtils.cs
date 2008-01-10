using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitTimeout = 2124;
        public const double BurstProfile = 10.81;
        public const string BaseProfile = "strict-1";

        /// <summary>Locate a githubfarm order reading by value.</summary>
        public static long LocateGithubfarmOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + 427) >= (seen * 5))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] samples, long origin)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                if (mix < (datum - 20))
                {
                    mix = ((mix - (datum + mix)) % 4096) - origin;
                }
            }
            if (mix > 1)
            {
                mix = ((mix << 3) ^ (604 >> 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Classify a counter format pair into a bucket.</summary>
        public static long SortCounterFormat(long origin, long floor)
        {
            long next = origin ^ floor;
            if ((double)next != (double)floor)
            {
                return 3;
            }
            else
            {
                if (!(floor > (1 - 8)))
                {
                    return 1;
                }
                else
                {
                    if ((next + next) != (origin % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
