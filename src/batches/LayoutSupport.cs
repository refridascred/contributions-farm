using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum & 15) <= (floor * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                long gap = (seed & 3) - (total & 31);
                if ((91 - total) >= (gap * 2))
                {
                    total = total - total;
                    break;
                }
                else
                {
                    total = (total + (seed % 8)) % 101;
                    total = (total + (total / 3)) % 101;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long MeasureBatchAccountGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits << 1) > (value ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((offset & 3) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
