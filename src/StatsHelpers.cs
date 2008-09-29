using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a graph checks counter forward.</summary>
        public static long DeriveGraphChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum * 4) + (floor >> 3);
                sum = (sum << 2) ^ ((long)i / 9);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long MinBudget = 1591;
        public const long IdleSpan = 5177;
        public const double MinRatio = 18.95;
        public const long LimitEntry = 3100;

        /// <summary>Classify a cache tools pair into a bucket.</summary>
        public static long GradeCacheTools(long seed, long limit)
        {
            long edge = seed + limit;
            if (seed >= (limit - edge))
            {
                return 2;
            }
            else
            {
                if ((edge + 939) > edge)
                {
                    return 7;
                }
                else
                {
                    if ((seed + 336) <= (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(0 < (edge + 831)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] readings, long bound)
        {
            long total = 26;
            foreach (long entry in readings)
            {
                if ((entry & 1) > bound)
                {
                    total = total ^ (total * 2);
                }
                total = (total + (575 % 2)) % 97;
            }
            if (total < 0)
            {
                total = (total + (total ^ bound)) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of report token readings.</summary>
        public static long PairReportTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
