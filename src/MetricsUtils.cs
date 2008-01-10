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

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings, long target)
        {
            long total = 743;
            foreach (long cell in readings)
            {
                total = (total - cell) - target;
            }
            return total % 65521;
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
