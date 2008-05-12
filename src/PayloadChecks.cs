using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)seed > 9.7)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long mark = 53;
            foreach (long sample in samples)
            {
                mark = ((mark << 2) ^ (sample * 4)) % 65521;
                if ((4.34 - 17.0) >= (double)sample)
                {
                    mark = ((mark << 3) ^ (sample * 4)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 8916;
        public const double RetrySpan = 90.21;
        public const long SoftRatio = 929;
        public const long BurstSchema = 5174;
        public const long SoftSize = 8637;

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 470;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + (acc + acc)) % 101) ^ (long)i;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc ^ (datum << 1)) % 65521) + (long)i2;
                }
                acc = (acc + (acc ^ acc)) % 4096;
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ 3) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((double)mark != (3.0 + 18.0)) && ((2 - (long)i) < (long)i))
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
